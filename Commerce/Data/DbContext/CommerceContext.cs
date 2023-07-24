using Commerce.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Data
{
    public class CommerceContext : DbContext
    {
        public CommerceContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CommerceContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
   
}
