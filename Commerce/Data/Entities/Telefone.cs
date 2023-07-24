using Commerce.Data.Classes;

namespace Commerce.Data.Entities
{
    public class Telefone : TEntity
    {
        public Guid UsuarioId { get; set; }
        public int DDD { get; set; }
        public string Numero { get; set; }
        public int Regiao { get; set; }
        public Usuario Usuario { get; set; }
    }
}
