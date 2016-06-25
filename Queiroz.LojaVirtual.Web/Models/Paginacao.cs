using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queiroz.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int PaginaAtual { get; set; }
        public int TotalItens { get; set; }
        public int TotalIensPorPaginas { get; set; }
        public int TotalPaginas{
            get {
                return (int)Math.Ceiling((decimal)TotalIensPorPaginas / TotalItens);
            }
        }


    }
}