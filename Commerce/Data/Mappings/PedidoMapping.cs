using Commerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.DataPedido).IsRequired().HasColumnType("DateTime");
            builder.Property(p => p.ModoPagamento).IsRequired();
            builder.Property(p => p.ValorTotal).IsRequired().HasColumnType("DECIMAL(11,2)");
        }
    }
}
