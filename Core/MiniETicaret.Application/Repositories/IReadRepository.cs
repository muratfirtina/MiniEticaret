using System.Linq.Expressions;
using MiniETicaret.Domain.Entities.Common;

namespace MiniETicaret.Application.Repositories;

public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
    Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
    Task<T> GetByIdAsync(string id);
}