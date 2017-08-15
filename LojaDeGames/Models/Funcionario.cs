using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaDeGames.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string Endereco { get; set; }
    }
}