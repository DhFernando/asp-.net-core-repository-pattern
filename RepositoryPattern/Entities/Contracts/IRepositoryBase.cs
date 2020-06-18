using RepositoryPattern.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Entities.Contracts
{
    public interface IRepositoryBase
    {
        Task<IEnumerable<User>> FindAll();

        Task<IQueryable<User>> GetUser(string UserId);
        void Create(User user);
        void Delete(User user);

    }
}
