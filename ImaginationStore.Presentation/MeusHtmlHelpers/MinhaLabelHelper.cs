using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImaginationStore.Presentation.MeusHtmlHelpers
{
    public class MinhaLabelHelper
    {
        public static string Label(string destino, string texto)
        {
            return String.Format("<label for='{0}'>{1}</label>", destino, texto);
        }
    }
}