﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
            //db.Agentes.ToList() --> SQL: select * from Agentes
            //constroi uma lista CommandBehavior os dados de todos os Agentes 
            //e envia-a 
            return View(db.Agentes.ToList());
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
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //vai procurar o Agente cujo ID foi Fornecido
            Agentes agentes = db.Agentes.Find(id);
            //se o agente nao for encontrado.+......+++..+.....
         
            if (agentes == null)
            {
                return HttpNotFound();
            }
            return View(agentes);
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
        public ActionResult Create([Bind(Include = "ID,Nome,Fotografia,Esquadra")] Agentes agentes)
        {
            //ModelState.IsValid -->confronta os dados fornecidos com o modelo
            //se não respeitar as regras do modelo, rejeita os dados
            if (ModelState.IsValid)
            {
                //adiciona na estrutura de dados, na memoria do servidor,
                //o objeto Agentes
                db.Agentes.Add(agentes);
                //faz 'commit'
                db.SaveChanges();
                //redireciona o utilizador para a pagina de inicio
                return RedirectToAction("Index");
            }
            //devolve os dados do agente na view
            return View(agentes);
        }

        // GET: Agentes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agentes agentes = db.Agentes.Find(id);
            if (agentes == null)
            {
                return HttpNotFound();
            }
            return View(agentes);
        }

        // POST: Agentes/Edit/5
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
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agentes agentes = db.Agentes.Find(id);
            if (agentes == null)
            {
                return HttpNotFound();
            }
            return View(agentes);
        }

        // POST: Agentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //procurar o agente 
            Agentes agentes = db.Agentes.Find(id);
            //remover a memória
            db.Agentes.Remove(agentes);
            //commit na BD
            db.SaveChanges();
            return RedirectToAction("Index");
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
