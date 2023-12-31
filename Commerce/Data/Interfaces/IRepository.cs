﻿using Commerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Commerce.Data.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Entidade
    {
        Task Adicionar(T entity);
        Task<T> ObterPorId(Guid id);
        Task<List<T>> ObterTodos();
        Task<int> Atualizar(T entity);
        Task Remover(Guid id);
        Task SalvarTodos(List<T> list);
        Task<T> Buscar(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> BuscarTodos (Expression<Func<T, bool>> expression);
        Task<int> SaveChanges();
    }
}
