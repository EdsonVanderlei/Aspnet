using Commerce.Data.Entities;
using Commerce.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Commerce.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Entidade, new()
    {

        protected readonly CommerceContext _commerceContext;
        protected readonly DbSet<T> _dbSet;

        public Repository(CommerceContext commerceContext)
        {
            _dbSet = commerceContext.Set<T>();
            _commerceContext = commerceContext;
        }
        async public Task Adicionar(T entity)
        {
            await _dbSet.AddAsync(entity);
            await SaveChanges();
        }
        async public Task<int> Atualizar(T entity)
        {
            _dbSet.Update(entity);
            return await SaveChanges();
        }
        public async Task<T> Buscar(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(expression);
        }
        public async Task<IEnumerable<T>> BuscarTodos(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AsNoTracking().Where(expression).ToListAsync();
        }
        public void Dispose()
        {
            _commerceContext.Dispose();
        }
        public async Task<T> ObterPorId(Guid id)
        {

            return await _dbSet.FindAsync(id);
        }
        public async Task<List<T>> ObterTodos()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }
        async public Task Remover(Guid id)
        {
            _dbSet.Remove(new T() { Id = id });
            await SaveChanges();
        }
        public async Task SalvarTodos(List<T> list)
        {
            await _dbSet.AddRangeAsync(list);
            await SaveChanges();
        }
        public async Task<int> SaveChanges()
        {
            return await _commerceContext.SaveChangesAsync();
        }
    }
}
