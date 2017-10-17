using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LojaDeGames.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Informe apenas numero")]
        public int Cpf { get; set; }
        [Required]
        public string Endereco { get; set; }
    }
}