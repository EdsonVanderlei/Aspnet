namespace Commerce.Data.Entities
{
    public class PedidoItem : Entidade
    {
        public Guid PedidoID { get; set; }
        public Guid ProdutoID { get; set; }
        public double Valor { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
    }
}
