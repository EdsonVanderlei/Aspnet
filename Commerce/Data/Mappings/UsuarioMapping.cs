using Commerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany<Pedido>(p => p.Pedidos).WithOne(p => p.Usuario);
            builder.HasOne<Endereco>(p => p.Endereco).WithOne(p => p.Usuario).HasForeignKey<Endereco>(p => p.UsuarioId);
            builder.Property(p => p.Nome).IsRequired().HasColumnType("varchar(100)");
            builder.Property(p => p.Email).IsRequired().HasColumnType("varchar(100)");
            builder.Property(p => p.Cpf).IsRequired().HasColumnType("varchar(14)");
            builder.Property(p => p.Rg).IsRequired().HasColumnType("varchar(9)");
            builder.HasIndex(p => p.Cpf).IsUnique();
            builder.HasIndex(p => p.Rg).IsUnique();
            builder.HasIndex(p => p.Email).IsUnique();
        }
    }
}
