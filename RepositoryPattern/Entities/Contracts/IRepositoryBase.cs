using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryPattern.Entities.Contracts
{
    public interface IRepositoryBase<T>
    {
        Task<IEnumerable<T>> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T , bool>> expression);
        Task Create(T entity);
        Task Delete(T entity);
    }
}
