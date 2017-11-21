using LojaDeGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaDeGames.Controllers
{
    [Authorize]
    public class GamesController : Controller
    {

        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

   //     static List<Jogo> listaJogos = new List<Jogo>()
     //   {
       //     new Jogo{Id = 1,Nome = "GTA V",Genero = "Ação",FaixaEtaria = "18+",Desenvolvedora =  "ROCKSTAR GAMES"},
        //    new Jogo{Id = 2,Nome = "Red Dead Redemption",Genero = "Aventura",FaixaEtaria = "18+",Desenvolvedora =  "ROCKSTAR GAMES"},
         //   new Jogo{Id = 3,Nome = "Monster Hunter",Genero = "Aventura",FaixaEtaria = "12+",Desenvolvedora =  "Capcom"},
           // new Jogo{Id = 4,Nome = "Street Fighter V",Genero = "Luta",FaixaEtaria = "12+",Desenvolvedora =  "Capcom"},
            //new Jogo{Id = 5,Nome = "Resident Evil VII",Genero = "Ação|Horror",FaixaEtaria = "16+",Desenvolvedora =  "Capcom"},
            //new Jogo{Id = 6,Nome = "Destiny 2",Genero = "Ação|Aventura",FaixaEtaria = "12+",Desenvolvedora =  "Bungie"}
        //};


        public ActionResult Index()
        {

            var gameIndexView = new JogoIndexViewModel()
            {
                Jogos = _context.Jogos.ToList()
            };

            return View(gameIndexView);

        }

        public ActionResult DetalhesJogos(int id)
        {
            if (id > _context.Jogos.Count()) return HttpNotFound();

            Jogo jogoDetalhe = _context.Jogos.Find(id);//(clientes => clientes.Id == id);

            return View(jogoDetalhe);

        }

        public ActionResult New()
        {
            var viewModel = new JogoIndexViewModel();

            return View("FormJogo", viewModel);
        }


        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        public ActionResult Save(Jogo jogo)
        {
            ModelState.Remove("jogo.Id");

            if (!ModelState.IsValid)
            {
                var viewModel = new JogoIndexViewModel
                {
                     Jogo = jogo
                };

                return View("FormJogo", viewModel);
            }

            if (jogo.Id != 0)
            {
                _context.Entry(jogo).State = System.Data.Entity.EntityState.Modified;
            }
            else
            {
                _context.Jogos.Add(jogo);
            }
            // armazena o cliente em memória

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var jogo = _context.Jogos.SingleOrDefault(c => c.Id == id);

            if (jogo == null)
                return HttpNotFound();

            var viewModel = new JogoIndexViewModel()
            {
                Jogo = jogo
            };

            return View("FormJogo", viewModel);
        }


        public ActionResult Delete(int id)
        {

            Jogo jogo = _context.Jogos.SingleOrDefault(c => c.Id == id);

            if (jogo == null)
            {
                return HttpNotFound();
            }
            else
            {
                _context.Jogos.Remove(jogo);
                _context.SaveChanges();
                return RedirectToAction("Index", jogo);
            }
        }
    }
}