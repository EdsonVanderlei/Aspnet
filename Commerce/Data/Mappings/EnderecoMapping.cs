using Commerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Logradouro).IsRequired().HasColumnType("varchar(100)");
            builder.Property(p => p.Bairro).IsRequired().HasColumnType("varchar(100)");
            builder.Property(p => p.Cidade).IsRequired().HasColumnType("varchar(100)");
            builder.Property(p => p.Estado).IsRequired().HasColumnType("varchar(100)");
            builder.Property(p => p.Cep).IsRequired().HasColumnType("varchar(11)");
            builder.Property(p => p.Complemento).IsRequired().HasColumnType("varchar(100)");
        }
    }
}
