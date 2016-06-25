using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Queiroz.LojaVirtual.Dominio.Repositorio;

namespace Queiroz.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        ProdutosRepositorio _repositorio;
        // GET: Vitrine
        public ActionResult ListaProdutos(int Pagina = 1)
        {
            int totalPorPaginas = 3;
            _repositorio = new ProdutosRepositorio();
            var produtos = from p in _repositorio.Produtos.Skip((Pagina - 1) * totalPorPaginas).Take(totalPorPaginas).OrderBy(p => p.Nome) 
                           select p;

            return View(produtos);
        }
    }
}