using Commerce.Data.Entities;

namespace Commerce.Data.Interfaces
{
    public interface IRepositoryUsuario : IRepository<Usuario>
    {
        Task<Usuario> UsuariosEnderecoPedidosTelefone(Guid id);
    }
}
