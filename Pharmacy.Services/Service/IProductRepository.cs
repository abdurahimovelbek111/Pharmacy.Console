using Pharm.Entity.Model;
using System.Collections.Generic;

namespace Pharmacy.Services.Service
{
     public  interface IProductRepository
    {
        IList<Product> GetAll(string search="");
    }
}