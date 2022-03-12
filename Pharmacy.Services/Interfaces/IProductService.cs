using Pharm.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Services.Interfaces
{
     public interface IProductService
    {
        IList<Product> GetAllProducts(string search);
        object GetAllProducts();
    }
}
