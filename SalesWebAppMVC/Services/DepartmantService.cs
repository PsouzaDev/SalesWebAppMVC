using SalesWebAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebAppMVC.Services
{
    public class DepartmantService
    {
        private readonly SalesWebAppMVCContext _context;

        public DepartmantService(SalesWebAppMVCContext context)
        {
            _context = context;
        }

        public List<Departmant> FindAll()
        {
            return _context.Departmant.OrderBy(dp => dp.Name).ToList();
        }
    }
}
