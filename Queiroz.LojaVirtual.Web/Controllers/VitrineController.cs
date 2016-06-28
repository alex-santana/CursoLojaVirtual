using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Queiroz.LojaVirtual.Dominio.Repositorio;
using Queiroz.LojaVirtual.Web.Models;
using Queiroz.LojaVirtual.Dominio.Entidades;

namespace Queiroz.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        ProdutosRepositorio _repositorio;
        int totalPorPaginas = 3;
        // GET: Vitrine
        public ActionResult ListaProdutos(string categoria, int Pagina = 1)
        {

            _repositorio = new ProdutosRepositorio();
            int itensTotal = _repositorio.Produtos.Where(x => categoria == null || x.Categoria == categoria).Count();
            //var produtos = from p in _repositorio.Produtos.Skip((Pagina - 1) * totalPorPaginas).Take(totalPorPaginas).OrderBy(p => p.Nome) 
            //               select p;

            //Url.Action()
            //var prod = from p in _repositorio.Produtos.Where(x => categoria == null || x.Categoria == categoria).Skip((Pagina - 1) * totalPorPaginas).Take(totalPorPaginas).OrderBy(p => p.Nome)
            //        //where p.Categoria == categoria
            //        select p;


            ProdutosViewModel model = new ProdutosViewModel()
            {
                Produtos = from p in _repositorio.Produtos.Where(x => categoria == null || x.Categoria == categoria).Skip((Pagina - 1) * totalPorPaginas).Take(totalPorPaginas).OrderBy(p => p.Nome)
                               //where p.Categoria == null || p.Categoria.Trim() == categoria
                           select p,

                Paginas = new Paginacao()
                {
                    ItensPorPagina = totalPorPaginas,
                    PaginaAtual = Pagina,
                    ItensTotal = itensTotal
                }

            };

            return View(model);
        }
    }
}