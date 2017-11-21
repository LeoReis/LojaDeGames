using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaDeGames.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set;}
        [Required]
        public string Genero { get; set; }
        [Required]
        public string FaixaEtaria { get; set; }
        [Required]
        public string Desenvolvedora { get; set; }


    }
}