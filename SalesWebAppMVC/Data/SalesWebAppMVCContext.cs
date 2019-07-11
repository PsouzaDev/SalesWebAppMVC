using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebAppMVC.Models
{
    public class SalesWebAppMVCContext : DbContext
    {
        public SalesWebAppMVCContext (DbContextOptions<SalesWebAppMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebAppMVC.Models.Departmant> Departmant { get; set; }
    }
}
