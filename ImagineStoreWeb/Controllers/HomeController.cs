using ImaginationStore.Integration.Repositories;
using System;
using System.Web.Mvc;
using NHibernate;
using System.Collections.Generic;
using ImaginationStore.Integration.Repositories;

namespace ImagineStoreWeb.Controllers
{
    public class HomeController : Controller
    {
        int id = 2;

        public ActionResult Menu()
        {
           // BuscarCategoria buscarcategoria = new BuscarCategoria();
          //  ViewBag.Categoria = buscarcategoria();
            return View();
        }
        void BuscarCategoria()
        {
           // System.Console.WriteLine(CategoriaRepository.BuscaCategoriaPorCodigo(id).nome);

        }

    }
}