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

        [Required(ErrorMessage ="O {0} é de preenchimento obrigatório!")]//atributo 'Nome' de preenchimento obrigatorio
        [RegularExpression("[A-Z][a-záéíóúãõàèìòùâêîôûäëöïüç]+(( | de | da | dos | d'|-)[A-Z][a-záéíóúãõàèìòùâêîôûäëöïüç]+){1,3}", ErrorMessage ="Nome Invalido")]
        [StringLength(40)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")]
        [StringLength(40)]
        public string Fotografia { get; set; }

        [Required(ErrorMessage = "A {0} é de preenchimento obrigatório!")]
        [RegularExpression("[A-Za-z 0-9-]+",ErrorMessage ="Nome Esquadra Invalido")]
        [StringLength(40)]
        public string Esquadra { get; set; }

        //complementar a informação sobre o relacionamento de um agente com as multas por 'ele passadas'
        public virtual ICollection<Multas>  ListaDeMultas { get; set; }


    }
}