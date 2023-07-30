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
            builder.Property(p => p.Modelo).IsRequired().HasColumnType("varchar(100)");
            builder.Property(p => p.Descricao).IsRequired().HasColumnType("varchar(100)");
            builder.HasOne(p => p.Marca).WithMany(p => p.Produtos);
            builder.Property(p => p.Valor).IsRequired().HasColumnType("DECIMAL(11,2)");
            builder.ToTable("Produtos");
        }
    }
}
