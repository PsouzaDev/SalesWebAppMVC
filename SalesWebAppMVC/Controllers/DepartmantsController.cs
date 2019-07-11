using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebAppMVC.Models;

namespace SalesWebAppMVC.Controllers
{
    public class DepartmantsController : Controller
    {
        public IActionResult Index()
        {
            List<Departmant> list = new List<Departmant>();
            list.Add(new Departmant { Id = 1, Name = "eletronics" });
            list.Add(new Departmant { Id = 2, Name = "fashion" });
            return View(list);
        }
    }
}