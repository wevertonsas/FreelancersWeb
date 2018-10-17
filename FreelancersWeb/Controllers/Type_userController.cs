using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FreelancersWeb.Models;

namespace FreelancersWeb.Controllers
{
    public class Type_userController : Controller
    {
        public IActionResult Index()
        {

            List<Type_user> list = new List<Type_user>();
            list.Add(new Type_user { Id = 1, Nome = "Empresa" });
            list.Add(new Type_user { Id = 2, Nome = "Freelancer" });
            list.Add(new Type_user { Id = 3, Nome = "Admin" });

            return View(list);
        }
    }
}