using Pharm.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Database.Interface
{
    interface IProductRepository
    {
        IList<Product> GetAll(string search = "");
        Product GetById(int id);
        void Delete(int id);
        Product Update(Product product);
        Product Add(Product product);
    }
}
