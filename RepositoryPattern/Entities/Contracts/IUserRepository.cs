using RepositoryPattern.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Entities.Contracts
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<IEnumerable<User>> FindAllUsers();

        Task<User> GetUserById(string UserId);
        Task CreateUser(User user);
        Task DeleteUser(User user);

    }
}
