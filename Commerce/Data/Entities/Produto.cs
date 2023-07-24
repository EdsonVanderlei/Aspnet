using Commerce.Data.Classes;

namespace Commerce.Data.Entities
{
    public class Produto : TEntity
    {
        public string Modelo { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public int Avaliacao { get; set; }

        public List<Pedido> Pedidos { get; set; }
        public Marca Marca { get; set; }

    }
}