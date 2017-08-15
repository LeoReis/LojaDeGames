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
        public ActionResult Cliente()
        {
            var cliente = new Cliente() { Nome = "Carlos", Cpf = 504184174, Endereco = "Joinville" };
            return View(cliente);
        }
    }
}