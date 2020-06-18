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
        IRepositoryBase _repositoryBase;
        public HomeController(IRepositoryBase repositoryBase)
        {
            this._repositoryBase = repositoryBase;
        }

        public async Task<IEnumerable<User>> Index()
        {
            return await _repositoryBase.FindAll();
        }

        public async Task<IEnumerable<User>> GetUsert()
        {
            return await _repositoryBase.GetUser("01");
        }

        [HttpPost]
        public IActionResult AddUser()
        {
            var user = new User() { UserId = "3" , UserBday = "cwo" , UserDep = "cdwj" , UserName = "dw" , UserRole = "CEO"};
            _repositoryBase.Create(user);
            return Json("done");    
        }
    }
}
