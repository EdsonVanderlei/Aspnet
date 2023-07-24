using Commerce.Data.Classes;
using System.ComponentModel.DataAnnotations;

namespace Commerce.Data.Entities
{
    public class Usuario : TEntity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public List<Telefone> Telefones { get; set; }
    }
}
