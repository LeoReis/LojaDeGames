using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaDeGames.Models
{
    public class Console
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Marca { get; set; }
        public MarcaType MarcaType { get; set; }

        // chave estrangeira
        [Display(Name = "Marca")]
        public byte MarcaTypeId { get; set; }
    }
}