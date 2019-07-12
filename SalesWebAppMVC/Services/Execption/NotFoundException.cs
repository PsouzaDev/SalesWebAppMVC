using System;

namespace SalesWebAppMVC.Services.Execption
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException (string message) : base(message)
        {

        }
    }
}
