using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Multas.Models;

namespace Multas.Controllers
{
    public class AgentesController : Controller
    {
        //cria um objeto privado, que representa a base de dados
        private MultasDb db = new MultasDb();

        // GET: Agentes
        public ActionResult Index()
        {
            //db.Agentes.ToList() --> SQL: select * from Agentes ORDER BY nome
            //constroi uma lista CommandBehavior os dados de todos os Agentes 
            //e envia-a 
            var listaAgentes = db.Agentes.ToList().OrderBy(a=>a.Nome);
            return View(listaAgentes);
        }

        // GET: Agentes/Details/5
        /// <summary>
        /// Ãpresenta os detalhes de um Agente
        /// </summary>
        /// <param name="id"> Representa a PK que identifica o Agente </param>
        /// <returns>  </returns>
        public ActionResult Details(int? id)
        {
            //int? - significa que pode haver valores nulos 

            //protege a execução do métedo contra a Não existencia de dados
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                //ou nao foi introduzido um ID válido ou foi introduzido um valor completamente errado
                return RedirectToAction("Index");
                
            }
            //vai procurar o Agente cujo ID foi Fornecido
            Agentes agente = db.Agentes.Find(id);
            //se o agente nao for encontrado.+......+++..+.....
         
            if (agente == null)
            {
                //return HttpNotFound();
                return RedirectToAction("Index");
            }
            return View(agente);
        }

        // GET: Agentes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agentes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nome,Esquadra")] Agentes agente, HttpPostedFileBase fileUploadFotografia)
        {
            // determinar o ID do novo Agente
            int novoID = 0;

            if(db.Agentes.Count() == 0){
                novoID = 1;
            }
            else
            {
                novoID = db.Agentes.Max(a => a.ID) + 1;
            }


            // atribuir o ID ao novo agente
            agente.ID = novoID;

            // var. auxiliar
            string nomeFotografia = "Agente_" + novoID + ".jpg";
            string caminhoParaFotografia = Path.Combine(Server.MapPath("~/imagens/"), nomeFotografia); // indica onde a imagem será guardada

            // verificar se chega efetivamente um ficheiro ao servidor
            if (fileUploadFotografia != null)
            {
                // guardar o nome da imagem na BD
                agente.Fotografia = nomeFotografia;
            }
            else
            {
                // não há imagem...
                ModelState.AddModelError("", "Não foi fornecida uma imagem..."); // gera MSG de erro
                return View(agente); // reenvia os dados do 'Agente' para a View
            }

            //    verificar se o ficheiro é realmente uma imagem ---> casa
            //    redimensionar a imagem --> ver em casa

            // ModelState.IsValid --> confronta os dados fornecidos com o modelo
            // se não respeitar as regras do modelo, rejeita os dados
            if (ModelState.IsValid)
            {
                try
                {
                    db.Agentes.Add(agente);
                    db.SaveChanges();
                    fileUploadFotografia.SaveAs(caminhoParaFotografia);
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Ocorreu um erro nao determinado...");
                }
            }

                // devolve os dados do agente à View
                return View(agente);
        }
        
        // GET: Agentes/Edit/5
        public ActionResult Edit(int? id)
        {
            //falta tratar das imagens

            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return RedirectToAction("Index");
            }
            Agentes agente = db.Agentes.Find(id);
            if (agente == null)
            {
                //return HttpNotFound();
                return RedirectToAction("Index");
            }
            return View(agente);
        }

        // POST: Agentes/Edit/
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Fotografia,Esquadra")] Agentes agentes)
        {
            //atualiza od dados do agente, na estrutura de dados em memória
            if (ModelState.IsValid)
            {
                db.Entry(agentes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agentes);
        }

        // GET: Agentes/Delete/5
        /// <summary>
        /// Procura os dados de um agente,
        /// e mostra-os no ecrã
        /// </summary>
        /// <param name="id"> o identificador do agente a pesquisar </param>
        /// <returns></returns>
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return RedirectToAction("Index");
            }
            Agentes agente = db.Agentes.Find(id);
            if (agente == null)
            {
                //return HttpNotFound();
                return RedirectToAction("Index");
            }
            return View(agente);
        }

        // POST: Agentes/Delete/5
        /// <summary>
        /// concretiza, torna definitiva quando possivel
        /// a remoção de um agente
        /// </summary>
        /// <param name="id"> o identificador do agente a remover </param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //procurar o agente 
            Agentes agente = db.Agentes.Find(id);
            try
            {
                //remover a memória
                db.Agentes.Remove(agente);
                //commit na BD
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                //gera uma mensagem de erro, a ser apresentada ao utilizador 
                ModelState.AddModelError("", string.Format("Não foi possivel remover o agente '{0}', porque existem {1} multas associadas a ele.", agente.Nome, agente.ListaDeMultas.Count));
            }

            //reenviar os dados +ara a view
            return View(agente);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
