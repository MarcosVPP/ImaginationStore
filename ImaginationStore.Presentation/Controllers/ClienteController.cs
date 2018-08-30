using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImaginationStore.Service.Service;
using ImaginationStore.Domain.Entities;

namespace ImaginationStore.Presentation.Controllers

{
    public class ClienteController : Controller
    {


        // GET: Cliente
<<<<<<< HEAD
        [HttpPost]
        public ActionResult Index(/*ClienteService salvarcliente*/)
=======
        public ActionResult Index()
>>>>>>> 11ea52c82ea9f04dd57a89017dc6bfbbac697085
        {
            object test;
            //Tentando chamar o metodo para salvar cliente
            //ClienteService.SalvarCliente(Cliente cliente);  => ClienteRepository.SalvarCliente(cliente);
            return View();
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
         //   BuscarCategoria();

            return View();

        }
 
        //Pesquisa categoria por ID
        void BuscarCategoria()
        {
            //System.Console.WriteLine(CategoriaRepository.BuscaCategoriaPorCodigo(id));
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
<<<<<<< HEAD
        }

=======
        }  
>>>>>>> 11ea52c82ea9f04dd57a89017dc6bfbbac697085
    }
}
