using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")] // o atributo 'Nome' é de preenchimento obrigatório
        [RegularExpression("[A-ZÂÍ][a-záéíóúãõàèìòùâêîôûäëïöüç.]+(( | de | da | dos | d'|-)[A-ZÂÍ][a-záéíóúãõàèìòùâêîôûäëïöüç.]+){1,3}",
              ErrorMessage = "O nome apenas aceita letras. Cada palavra começa por uma maiúscula, seguida de minúsculas...")]
        [StringLength(40)]
        public string Nome { get; set; }

        //[Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        public string Fotografia { get; set; }

        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        [RegularExpression("[A-Za-záéíóúãõàèìòùâêîôûäëïöüç 0-9-]+", ErrorMessage = "Escreva um nome aceitável...")]
        public string Esquadra { get; set; }

        // complementar a informação sobre o relacionamento
        // de um Agente com as Multas por ele 'passadas'
        public virtual ICollection<Multas> ListaDeMultas { get; set; }

    }
}