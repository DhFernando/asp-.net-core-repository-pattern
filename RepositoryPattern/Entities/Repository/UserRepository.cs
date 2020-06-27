using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Entities.Contracts;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Entities.Repository
{
    public class UserRepository : RepositoryBase<User> , IUserRepository
    { 
        public UserRepository(RepositoryPatternContext context) : base(context) { }
        public async Task CreateUser(User user)
        {
            await Create(user);
        }

        public async Task DeleteUser(User user)
        {
            await Delete(user);
        }

        public async Task<IEnumerable<User>> FindAllUsers()
        {
            return await FindAll();
        }


        public async Task<User> GetUserById(String UserId)
        {
            return await FindByCondition(u => u.UserId.Equals(UserId.ToString())).FirstOrDefaultAsync();
        }
    }   
}
