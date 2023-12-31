﻿using Commerce.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Commerce.Models
{
    public class UsuarioDTO
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
