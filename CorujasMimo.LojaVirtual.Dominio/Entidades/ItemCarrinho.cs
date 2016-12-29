using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorujasMimo.LojaVirtual.Dominio.Entidades
{
    public class ItemCarrinho
    {
        public Produtos Produtos { get; set; }
        public int Quantidade { get; set; }
    }
}
