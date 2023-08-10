using System.ComponentModel.DataAnnotations;

namespace Commerce.Models
{
    public class Login
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório !")]
        [StringLength(14,MinimumLength = 11,ErrorMessage = "O campo {0} deve conter entre {1} e {2} caracteres !")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório !")]
        public string Senha { get; set; }
    }
}
