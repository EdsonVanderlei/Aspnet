using Commerce.Data.Classes;

namespace Commerce.Data.Entities
{
    public class Endereco : TEntity
    {
        public Guid UsuarioId { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public Usuario Usuario { get; set; }
    }
}