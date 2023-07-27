namespace Commerce.Data.Entities
{
    public class PedidoProduto : Entidade
    {
        public double Valor { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
