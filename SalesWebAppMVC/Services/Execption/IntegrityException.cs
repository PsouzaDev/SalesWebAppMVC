using System;

namespace SalesWebAppMVC.Services.Execption
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {
                
        }
    }
}
