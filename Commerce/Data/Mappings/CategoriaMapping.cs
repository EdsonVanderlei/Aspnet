using Commerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Numerics;

namespace Commerce.Data.Mappings
{
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(c => c.Produtos).WithOne(p => p.Categoria);
            builder.Property(p => p.Descricao).IsRequired().HasColumnType("varchar(100)");
            builder.Property(p => p.Nome).IsRequired().HasColumnType("varchar(50)");
            builder.ToTable("Categorias");
        }
    }
}
