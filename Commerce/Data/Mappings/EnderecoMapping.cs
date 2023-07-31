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
            builder.HasOne(e => e.Usuario).WithOne( u => u.Endereco);
            // builder.HasOne<Usuario>(p => p.Usuario).WithOne(p => p.Endereco).HasForeignKey<Usuario>(p => p.EnderecoId);
            builder.HasMany(p => p.Entregas).WithOne(p => p.Endereco);
            builder.Property(p => p.Numero).IsRequired().HasColumnType("bigint");
            builder.Property(p => p.Logradouro).IsRequired().HasColumnType("varchar(70)");
            builder.Property(p => p.Bairro).IsRequired().HasColumnType("varchar(40)");
            builder.Property(p => p.Cidade).IsRequired().HasColumnType("varchar(70)");
            builder.Property(p => p.Estado).IsRequired().HasColumnType("varchar(2)");
            builder.Property(p => p.Cep).IsRequired().HasColumnType("varchar(11)");
            builder.Property(p => p.Complemento).HasColumnType("varchar(30)");
            builder.ToTable("Enderecos");
        }
    }
}
