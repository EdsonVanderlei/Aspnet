using Commerce.Data.Enums;

namespace Commerce.Data.Entities
{
    public class Pedido : Entidade
    {
        public Guid UsuarioId { get; set; }
        public Status Status { get; set; }
        public DateTime DataPedido { get; set; }
        public Pagamento ModoPagamento { get; set; }
        public int PrazoDias { get; set; }
        public double ValorFrete { get; set; }
        public double ValorTotal { get; set; }
        public Usuario Usuario { get; set; }
        public List<PedidoItem> PedidosItens { get; set; }
    }
}