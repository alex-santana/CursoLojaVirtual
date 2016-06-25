using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Queiroz.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        //private static StringBuilder resultado = new StringBuilder();

        public static MvcHtmlString PageLinks(this HtmlHelper html, Models.Paginacao paginacao, Func<int, string> stringUrl)
        {
            StringBuilder resultado = new StringBuilder();
            for (int i = 0; i < paginacao.TotalIensPorPaginas; i++)
            {
                TagBuilder tb = new TagBuilder("a");
                tb.MergeAttribute("href", stringUrl(i));
                tb.InnerHtml = i.ToString();

                if (i == paginacao.PaginaAtual)
                {
                    tb.AddCssClass("selected");
                    tb.AddCssClass("btn-primary");
                }
                tb.AddCssClass("btn btn-default");
                resultado.Append(tb);
            }

            return MvcHtmlString.Create(resultado.ToString());
            
        }
    }
}