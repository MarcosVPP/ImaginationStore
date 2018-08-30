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
        public ActionResult Index(/*ClienteService salvarcliente*/)
        {
            return View();
        }


        // GET: Cliente
        [HttpPost]
<<<<<<< HEAD
        public ActionResult Get(Cliente cliente)

=======
        public ActionResult Get(/*ClienteService salvarcliente*/)
>>>>>>> 9bf0e8d14de279917d8914df42525cb2d8c23e36
        {
            cliente = (new ClienteService()).Get(cliente.Codigo);

            //object test;
            //Tentando chamar o metodo para salvar cliente
            //ClienteService.SalvarCliente(Cliente cliente);  => ClienteRepository.SalvarCliente(cliente);
            return View("Index", cliente);
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

=======
        }
>>>>>>> 9bf0e8d14de279917d8914df42525cb2d8c23e36
        }
    }

