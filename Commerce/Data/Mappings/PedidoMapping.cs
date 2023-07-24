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

            builder.HasMany<Produto>(p => p.Produtos).WithMany(p => p.Pedidos);
        }
    }
}
