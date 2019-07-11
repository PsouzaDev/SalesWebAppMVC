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

        public DbSet<Departmant> Departmant { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
