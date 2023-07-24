using Commerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.Mappings
{
    public class PedidoItemMapping : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne<Pedido>(p => p.Pedido).WithMany(p => p.PedidosItens).HasForeignKey(p => p.PedidoID);
            builder.HasOne<Produto>(p => p.Produto).WithMany(p => p.PedidosItens).HasForeignKey(p => p.ProdutoID);
        }
    }
}
