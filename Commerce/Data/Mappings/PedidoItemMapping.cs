using Commerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.Mappings
{
    public class PedidoItemMapping : IEntityTypeConfiguration<PedidoProduto>
    {
        public void Configure(EntityTypeBuilder<PedidoProduto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.Pedido).WithMany(p => p.PedidosItens);
            builder.HasOne(p => p.Produto).WithMany(p => p.PedidosItens);
            builder.Property(p => p.Valor).IsRequired().HasColumnType("DECIMAL(11,2)");
            builder.ToTable("PedidosProdutos");
        }
    }
}
