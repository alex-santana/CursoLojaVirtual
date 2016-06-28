using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Queiroz.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int PaginaAtual { get; set; }
        public int ItensTotal { get; set; }
        public int ItensPorPagina { get; set; }
        public int TotalPagina{
            get {
                return (int)Math.Ceiling((decimal)ItensTotal / ItensPorPagina);
            }
        }


    }
}