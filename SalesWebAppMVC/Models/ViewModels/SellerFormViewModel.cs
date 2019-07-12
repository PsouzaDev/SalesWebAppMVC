using System.Collections.Generic;

namespace SalesWebAppMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Departmant> Departmants { get; set; }

    }
}
