using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Queiroz.LojaVirtual.Dominio.Repositorio;

namespace Queiroz.LojaVirtual.Web.Controllers
{
    public class CatergoriaController : Controller
    {
        ProdutosRepositorio _reporsitorio;
        // GET: Catergoria
        public PartialViewResult Menu(string categoria = null)
        {
            ViewBag.CategoriaSelecionada = categoria;

            IEnumerable<string> categorias = _reporsitorio.Produtos
                                                            .Select(c => c.Categoria)
                                                            .Distinct()
                                                            .OrderBy(c => c);
            return PartialView(categorias);
        }
    }
}