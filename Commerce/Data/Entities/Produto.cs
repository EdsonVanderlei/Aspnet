namespace Commerce.Data.Entities
{
    public class Produto : Entidade
    {
        public string Modelo { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public int Avaliacao { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public List<PedidoProduto> PedidosItens { get; set; }
    }
}