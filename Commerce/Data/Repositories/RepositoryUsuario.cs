using Commerce.Data.Entities;
using Commerce.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Data.Repositories
{
    public class RepositoryUsuario : Repository<Usuario> , IRepositoryUsuario
    {
        public RepositoryUsuario(CommerceContext commerceContext) : base(commerceContext){}

        async public Task<bool> ExisteCpf(string cpf)
        {
           return await  _dbSet.Where(p => p.Cpf == cpf).AnyAsync();
        }

        async public Task<bool> ExisteEmail(string email)
        {
            return await _dbSet.Where(p => p.Email == email).AnyAsync();
        }

        async public Task<bool> ExisteRg(string rg)
        {
            return await _dbSet.Where(p => p.Rg == rg).AnyAsync();
        }

        async public Task<Usuario> UsuarioEnderecoPedido(Guid id)
        {
            return await  _dbSet.Include(p => p.Pedidos).Include(p => p.Endereco).FirstOrDefaultAsync(p => p.Id == id);
        }

        async public Task<List<Usuario>> UsuariosEnderecoPedido()
        {
            return await _dbSet.AsNoTracking().Include(p => p.Pedidos).Include(p => p.Endereco).ToListAsync();
        }
    }
}
