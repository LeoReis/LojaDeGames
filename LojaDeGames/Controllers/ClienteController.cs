using LojaDeGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var cliente = _context.Clientes.ToList();
            return View(cliente);
        }

        public ActionResult DetalhesClientes(int id)
        {
            if (id > listaCliente.Count) return HttpNotFound();

            Cliente clientesDetalhe = listaCliente.Find(clientes => clientes.Id == id);

            return View(clientesDetalhe);
        }
    }
}