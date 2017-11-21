using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaDeGames.Models
{
    public class JogoIndexViewModel
    {
        public List<Jogo> Jogos { get; set; }

        public Jogo Jogo { get; set; }
        public string Title
        {
            get
            {
                if (Jogo != null && Jogo.Id != 0)
                    return "Editar Jogo";

                return "Novo Jogo";
            }
        }
    }
}