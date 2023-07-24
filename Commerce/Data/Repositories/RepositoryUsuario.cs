using Commerce.Data.Entities;
using Commerce.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Data.Repositories
{
    public class RepositoryUsuario : Repository<Usuario> , IRepositoryUsuario
    {
        public RepositoryUsuario(CommerceContext commerceContext) : base(commerceContext)
        {
        }
        async public Task<Usuario> UsuariosEnderecoPedidosTelefone(Guid id)
        {
            return await  _dbSet.Include(p => p.Pedidos).Include(p => p.Telefones).Include(p => p.Endereco).FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
