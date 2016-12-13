using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorujasMimo.LojaVirtual.Dominio.Entidades;

namespace CorujasMimo.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Produtos> Produtos
        {
            get { return _context.Produtos; }
        }
    }
}
