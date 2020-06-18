using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Entities.Contracts;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Entities.Repository
{
    public class UserRepository : IRepositoryBase
    {
        private readonly RepositoryPatternContext _context;
        public UserRepository(RepositoryPatternContext context)
        {
            this._context = context;
        }
        public  void Create(User user)
        {
             _context.Set<User>().Add(user);
             _context.SaveChanges();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> FindAll()
        {
            return await _context.Set<User>().ToListAsync();
        }


        public async Task<IQueryable<User>> GetUser(string UserId)
        {
            return  _context.Set<User>().Where(user => user.UserId==(UserId.ToString()));
        }
    }
}
