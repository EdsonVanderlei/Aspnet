namespace Commerce.Data.Entities
{
    public class Entrega : Entidade
    {
        public Guid PedidoId { get; set; }
        public decimal ValorFrete { get; set; }
        public int PrazoDias { get; set; }
        public Endereco Endereco { get; set; }
        public Pedido Pedido { get; set; }
    }
}
