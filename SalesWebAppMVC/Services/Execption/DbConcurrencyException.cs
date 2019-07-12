using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebAppMVC.Services.Execption
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException (string message) : base(message)
        {

        }
    }
}
