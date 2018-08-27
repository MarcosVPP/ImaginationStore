using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImaginationStore.Domain.Entities;
using System.Web.Mvc;

namespace ImagineStoreWeb.Controllers
{
    public class HomeController : Controller
    {        

        public ActionResult Menu()
        {
            return View();
        }

    }
}