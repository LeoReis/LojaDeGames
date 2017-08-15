using LojaDeGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaDeGames.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ActionResult Random()
        {
            var game = new Jogo() { Id = 5,Nome ="GTA V"};
            return View(game);
        }
    }
}