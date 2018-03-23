using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Agentes
    {
        public Agentes()
        {
            ListaDeMultas = new HashSet<Multas>();
        }

        [Key]
        public int ID { get; set; } //Chave Primária

        public string Nome { get; set; }

        public string Fotografia { get; set; }

        public string Esquadra { get; set; }

        //complementar a informação sobre o relacionamento de um agente com as multas por 'ele passadas'
        public virtual ICollection<Multas>  ListaDeMultas { get; set; }


    }
}