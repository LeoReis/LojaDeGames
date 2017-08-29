using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaDeGames.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public string Genero { get; set; }
        public string FaixaEtaria { get; set; }
        public string Desenvolvedora { get; set; }


    }
}