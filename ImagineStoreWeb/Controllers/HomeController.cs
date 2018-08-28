using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImaginationStore.Domain.Entities;
using System.Web.Mvc;
using ImaginationStore.Integration.Repositories;

namespace ImagineStoreWeb.Controllers
{
    public class HomeController : Controller
    {
        int id = 2;

        public ActionResult Menu()
        {
           
            ViewBag.BuscarCategoria();

            return View();
        }

        //Classe para buscar Categoria por ID somente
        void BuscarCategoria()
        {
           Console.WriteLine(CategoriaRepository.BuscaProdutoPorCodigo(id).Nome);
           
        }

    }
}