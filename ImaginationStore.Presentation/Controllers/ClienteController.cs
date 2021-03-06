﻿using ImaginationStore.Domain.Entities;
using ImaginationStore.Service.Service;
using System.Web.Mvc;

namespace ImaginationStore.Presentation.Controllers

{
    public class ClienteController : Controller
    {
        public ActionResult Index()
        {
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
    [HttpPost]                 //Cliente cliente
        public ActionResult Create(Cliente cliente)
        {
            try
            {

                cliente = new ClienteService().Post(cliente.Codigo);
                cliente = new ClienteService().Post(cliente.Nome);
                cliente = new ClienteService().Post(cliente.Telefone);
                cliente = new ClienteService().Post(cliente.Filiacao);
                cliente = new ClienteService().Post(cliente.LimiteDeCredito);
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
        }
    }
}

