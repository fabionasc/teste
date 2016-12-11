using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Loja.LojaVirtual.Dominio.Entidade;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Loja.LojaVirtual.Dominio.Repositorio
{
    public class EFDbContext :DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }

    }
}
