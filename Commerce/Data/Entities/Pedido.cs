using Commerce.Data.Enums;

namespace Commerce.Data.Entities
{
    public class Pedido : Entidade
    {
        public Guid UsuarioId { get; set; }
        public Status Status { get; set; }
        public DateTime DataPedido { get; set; }
        public Pagamento ModoPagamento { get; set; }
        public decimal ValorTotal { get; set; }
        public Usuario Usuario { get; set; }
        public Entrega Entrega { get; set; }
        public List<PedidoProduto> PedidosItens { get; set; }
    }
}