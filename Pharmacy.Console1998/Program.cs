using Pharmacy.Services.Interfaces;
using System;

namespace Pharmacy.Console1998
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductService();
            var product = productService.GetAllProducts();
            Console.WriteLine("Hello World!");
        }
    }
}
