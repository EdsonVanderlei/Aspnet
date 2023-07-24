using Commerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.Mappings
{
    public class TelefoneMapping : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne<Usuario>(p => p.Usuario).WithMany(p => p.Telefones).HasForeignKey(p => p.UsuarioId);
            builder.Property(p => p.Numero).HasColumnType("varchar(10)");
            builder.HasIndex(p => p.Numero).IsUnique();
        }
    }
}
