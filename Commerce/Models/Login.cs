using System.ComponentModel.DataAnnotations;

namespace Commerce.Models
{
    public class Login
    {
        public string CPF { get; set; }
        public string Senha { get; set; }
    }
}
