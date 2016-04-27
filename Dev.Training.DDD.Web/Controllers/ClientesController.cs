using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Dev.Training.DDD.Application.Interfaces;
using Dev.Training.DDD.Domain.Entities;
using Dev.Training.DDD.Web.ViewModels;

namespace Dev.Training.DDD.Web.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clientApp;

        public ClientesController(IClienteAppService clientApp)
        {
            _clientApp = clientApp;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var clientViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clientApp.GetAll());
            return View(clientViewModel);
        }

        public ActionResult GetSpecialClients()
        {
            var clientViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clientApp.GetSpecialClients());
            return View(clientViewModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var clientViewModel = Mapper.Map<Cliente, ClienteViewModel>(_clientApp.GetById(id));
            return View(clientViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel client)
        {
            try
            {
                var modelViewClient = Mapper.Map<ClienteViewModel, Cliente>(client);
                _clientApp.Add(modelViewClient);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var clientViewModel = Mapper.Map<Cliente, ClienteViewModel>(_clientApp.GetById(id));
            return View(clientViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel client)
        {
            if (ModelState.IsValid)
            {
                var modelViewClient = Mapper.Map<ClienteViewModel, Cliente>(client);
                _clientApp.Update(modelViewClient);

                return RedirectToAction("Index");
            }
            return View(client);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var clientViewModel = Mapper.Map<Cliente, ClienteViewModel>(_clientApp.GetById(id));
            return View(clientViewModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var clientViewModel = _clientApp.GetById(id);
            _clientApp.Remove(clientViewModel);

            return RedirectToAction("Index");
        }
    }
}
