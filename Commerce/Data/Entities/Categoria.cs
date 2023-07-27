﻿namespace Commerce.Data.Entities
{
    public class Categoria : Entidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
