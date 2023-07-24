namespace Commerce.Data.Entities
{
    public class Produto : Entidade
    {
        public string Modelo { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public int Avaliacao { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public Marca Marca { get; set; }
        public List<PedidoItem> PedidosItens { get; set; }
    }
}