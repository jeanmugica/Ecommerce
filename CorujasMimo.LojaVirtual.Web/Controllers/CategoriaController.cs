using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CorujasMimo.LojaVirtual.Dominio.Entidades;
using CorujasMimo.LojaVirtual.Dominio.Repositorio;

namespace CorujasMimo.LojaVirtual.Web.Controllers
{
    public class CategoriaController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public PartialViewResult Menu(string categoria = null)
        {
            ViewBag.CategoriaSelecionada = categoria;

            _repositorio = new ProdutosRepositorio();

            IEnumerable<string> categorias = _repositorio.Produtos
                .Select(c => c.Categoria)
                .Distinct()
                .OrderBy(c => c);

            return PartialView(categorias);
        }
    }
}