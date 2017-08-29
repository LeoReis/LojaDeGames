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
        static List<Jogo> listaJogos = new List<Jogo>()
        {
            new Jogo{Id = 1,Nome = "GTA V",Genero = "Ação",FaixaEtaria = "18+",Desenvolvedora =  "ROCKSTAR GAMES"},
            new Jogo{Id = 2,Nome = "Red Dead Redemption",Genero = "Aventura",FaixaEtaria = "18+",Desenvolvedora =  "ROCKSTAR GAMES"},
            new Jogo{Id = 3,Nome = "Monster Hunter",Genero = "Aventura",FaixaEtaria = "12+",Desenvolvedora =  "Capcom"},
            new Jogo{Id = 4,Nome = "Street Fighter V",Genero = "Luta",FaixaEtaria = "12+",Desenvolvedora =  "Capcom"},
            new Jogo{Id = 5,Nome = "Resident Evil IV",Genero = "Ação|Horror",FaixaEtaria = "16+",Desenvolvedora =  "Capcom"}
        };


        public ActionResult Index()
        {
            var gameIndexView = new GameIndexViewModel()
            {
                Jogos = listaJogos
            };
            return View(gameIndexView);
        }

        public ActionResult DetalhesJogos(int id)
        {
            if (id > listaJogos.Count) return HttpNotFound();

            Jogo jogoDetalhe = listaJogos.Find(jogos => jogos.Id == id);

            return View(jogoDetalhe);
        }
    }
}