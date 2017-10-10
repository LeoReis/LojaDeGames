using LojaDeGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LojaDeGames.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        private ApplicationDbContext _context;

        public ClienteController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //static List<Cliente> listaCliente = new List<Cliente>()
        //{
        //    new Cliente {Id = 1, Nome = "Leonardo Reis",Cpf = 15645648, Endereco = "Jaraguá do Sul" },
        //    new Cliente {Id = 2, Nome = "Lauro Reis",Cpf = 15645648, Endereco = "Arroio do Sal" },
        //    new Cliente {Id = 3, Nome = "Anderson Boer",Cpf = 15645648, Endereco = "Torres" },
        //    new Cliente {Id = 4, Nome = "Neuza Maria",Cpf = 15645648, Endereco = "Torres" },
        //    new Cliente {Id = 5, Nome = "Luis Alberto Boer",Cpf = 15645648, Endereco = "Torres" },
        //};
        public ActionResult IndexCliente()
        {

            var clienteIndexView = new ClienteIndexViewModel()
            {
                Clientes = _context.Clientes.ToList()
            };
           
            return View(clienteIndexView);
        }

        public ActionResult DetalhesClientes(int id)
        {
            
            if (id > _context.Clientes.Count()) return HttpNotFound();

            Cliente clientesDetalhe = _context.Clientes.Find(id);//(clientes => clientes.Id == id);

            return View(clientesDetalhe);

        }

        public ActionResult New()
        {
            var viewModel = new ClienteIndexViewModel();
            
            return View("FormCliente", viewModel);
        }

        [HttpPost] // só será acessada com POST
        public ActionResult Save(Cliente cliente) // recebemos um cliente
        {
            if (cliente.Id != 0)
            {
                _context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
            }
            else {
                _context.Clientes.Add(cliente);
            }
            // armazena o cliente em memória
            
            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("IndexCliente");
        }

        public ActionResult Edit(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return HttpNotFound();

            var viewModel = new ClienteIndexViewModel
            {
                Cliente = cliente
            };

            return View("FormCliente", viewModel);
        }


        public ActionResult Delete(int id)
        {

            Cliente cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            else
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
                return RedirectToAction("IndexCliente",cliente);
                return View(cliente);
            }
        }

        //[AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult Delete(int id, string confirmButton)
        //{

        //    Cliente cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

        //    if (cliente == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    _context.Clientes.Remove(cliente);
        //    _context.SaveChanges();

        //    return View("Deleted");
        //}

    }
}