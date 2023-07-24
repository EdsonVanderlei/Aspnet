using Commerce.Data.Classes;
using Commerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Commerce.Data.Interfaces
{
    public interface IRepository<T> : IDisposable where T : TEntity
    {
        Task Adicionar(T entity);
        Task<T> ObterPorId(Guid id);
        Task<List<T>> ObterTodos();
        Task Atualizar(T entity);
        Task Remover(Guid id);
        Task<IEnumerable<T>> Buscar (Expression<Func<T, bool>> expression);
        Task<int> SaveChanges();
    }
}
