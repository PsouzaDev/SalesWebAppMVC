using SalesWebAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebAppMVC.Services
{
    public class DepartmantService
    {
        private readonly SalesWebAppMVCContext _context;

        public DepartmantService(SalesWebAppMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Departmant>> FindAllAsync()
        {
            return await _context.Departmant.OrderBy(dp => dp.Name).ToListAsync();
        }
    }
}
