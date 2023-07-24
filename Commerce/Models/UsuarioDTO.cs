using Commerce.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Commerce.Models
{
    public class UsuarioDTO
    {
        [Required(ErrorMessage = "Nome é Obrigatório")]
        [StringLength(60,MinimumLength =10, ErrorMessage = "Digite um nome entre 10 e 60 caracteres ")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "CPF é Obrigatório")]
        [StringLength( 11,ErrorMessage = "Digite um CPF de 11 digitos")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Senha é Obrigatória")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "E-mail é Obrigatória")]
        public string Email { get; set; }
        [Required(ErrorMessage = "RG é Obrigatória")]
        public string Rg { get; set; }
        [Required(ErrorMessage = "DateTime é Obrigatória")]
        public DateTime DataNascimento { get; set; }
    }
}
