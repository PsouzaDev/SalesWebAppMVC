using SalesWebAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebAppMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebAppMVCContext _context;

        public SellerService(SalesWebAppMVCContext context)
        {
            _context = context;
        }

        public IEnumerable<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }


    }
}
