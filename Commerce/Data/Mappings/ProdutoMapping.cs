using Commerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Modelo).IsRequired().HasColumnType("varchar(50)");
            builder.Property(p => p.Descricao).IsRequired().HasColumnType("varchar(100)");
            builder.HasOne<Marca>(p => p.Marca).WithMany(p => p.Produtos);
        }
    }
}
