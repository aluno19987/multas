using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class MultasDb : DbContext
    {
        //construtor da classe
        public MultasDb() : base("MultasDbConnectionString")
        {

        }

        //identificar as tabelas da base de dados
        public virtual DbSet<Multas> Multas { get; set; }

        public virtual DbSet<Condutores> Condutores { get; set; }

        public virtual DbSet<Viaturas> Viaturas { get; set; }

        public virtual DbSet<Agentes> Agentes { get; set; }

        /// <summary>
        /// configura a forma como as tabelas são criadas
        /// </summary>
        /// <param name="modelBuilder"> objeto que referencia ao gerador de base de dados</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}