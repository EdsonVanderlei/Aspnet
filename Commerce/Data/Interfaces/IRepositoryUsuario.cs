using Commerce.Data.Entities;

namespace Commerce.Data.Interfaces
{
    public interface IRepositoryUsuario : IRepository<Usuario>
    {
        Task<Usuario> UsuarioEnderecoPedido(Guid id);
        Task<List<Usuario>> UsuariosEnderecoPedido();
    }
}
