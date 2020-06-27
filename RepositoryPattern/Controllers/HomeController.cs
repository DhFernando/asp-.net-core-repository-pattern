using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepositoryPattern.Entities.Contracts;
using RepositoryPattern.Models;

namespace RepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        IUserRepository _repositoryBase;
        public HomeController(IUserRepository repositoryBase)
        {
            this._repositoryBase = repositoryBase;
        }

        public async Task<IEnumerable<User>> Index()
        {
            return await _repositoryBase.FindAllUsers();
        }

        public async Task<IActionResult> GetUserById()
        {
            return Ok(await _repositoryBase.GetUserById("01"));
        }

        [HttpPost]
        public async Task<IActionResult> AddUser()
        {
            var user = new User() { UserId = "3" , UserBday = "cwo" , UserDep = "cdwj" , UserName = "dw" , UserRole = "CEO"};
            await _repositoryBase.CreateUser(user);
            return Ok(Json("Done"));    
        }
    }
}
