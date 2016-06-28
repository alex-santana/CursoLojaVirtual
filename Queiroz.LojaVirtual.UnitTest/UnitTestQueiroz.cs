using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Queiroz.LojaVirtual.Web;
using Queiroz.LojaVirtual.Web.Models;
using Queiroz.LojaVirtual.Web.HtmlHelpers;

namespace Queiroz.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestQuerioz
    {
        [TestMethod]
        public void TestarSeAPaginacaoEstaSendoGeradaCorretamente()
        {
            //Arrange
            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao() { ItensPorPagina = 8, ItensTotal = 28, PaginaAtual = 2 };
            Func<int, string> stringUrl = i => "Pagina" + i;

            //Act
            MvcHtmlString resul = html.PageLinks(paginacao, stringUrl);

            //Assent
            Assert.AreEqual(@"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                            + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                            + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resul.ToString());


        }
}
}
