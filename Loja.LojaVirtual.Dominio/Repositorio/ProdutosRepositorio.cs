using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.LojaVirtual.Dominio.Entidade;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Loja.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EFDbContext _context = new EFDbContext();
        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }
            

    }
}
