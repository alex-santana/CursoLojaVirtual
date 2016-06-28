using Queiroz.LojaVirtual.Dominio.Entidades;
using Queiroz.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queiroz.LojaVirtual.Web.Models
{
    public class ProdutosViewModel
    {
        public IEnumerable<Produto> Produtos;

        public Paginacao Paginas { get; set; }

        public string CategoriaAtual {get; set;}
    }
}