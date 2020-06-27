using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Entities.Contracts;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryPattern.Entities.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly RepositoryPatternContext _context;
        public RepositoryBase(RepositoryPatternContext context)
        {
            this._context = context;
        }
        public async Task Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
    }
}
