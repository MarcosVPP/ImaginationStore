using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImaginationStore.Presentation.MeusHtmlHelpers
{
    public class MinhaLabelHelper
    {
        //Label esquerda para direita(entrada dos dados)
        public static string LabelE(string destino, string texto)
        {
            //Label para receber campos e escrever os nomes dos campos, da direita para direita.
            return String.Format("<label for='{0}'>{1}</label>", destino, texto);
        }
        //Label direita para esquerda(entrada dos dados)
        public static string LabelD(string destino, string texto)
        {
            //Label para receber campos e escrever os nomes dos campos, da direita para esquerda.
            return String.Format("<label for='{1}'>{0}</label>", destino, texto);
        }
    }
}