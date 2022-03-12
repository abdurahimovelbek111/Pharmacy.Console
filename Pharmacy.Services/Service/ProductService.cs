using Pharm.Entity.Model;
using Pharmacy.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Services.Service
{
    class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        public ProductService()
        {
            _productRepository = new ProductRepository();
        }
        public IList<Product> GetAllProducts(string search) => _productRepository.GetAll(search);

        public object GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
