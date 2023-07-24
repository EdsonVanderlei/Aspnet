using Commerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.Mappings
{
    public class MarcaMapping : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Nome).IsRequired().HasColumnType("varchar(100)");
            builder.Property(p => p.Descricao).IsRequired().HasColumnType("varchar(100)");
        }
    }
}
