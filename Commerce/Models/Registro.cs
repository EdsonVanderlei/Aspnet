using System.ComponentModel.DataAnnotations;

namespace Commerce.Models
{
    public class Registro
    {
        public string CPF { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string ConfirmaSenha { get; set; }
    }
}
