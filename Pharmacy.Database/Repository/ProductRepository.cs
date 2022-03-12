using Pharm.Entity.Model;
using Pharmacy.Database.Connections;
using Pharmacy.Database.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Pharmacy.Database.Repository
{
    class ProductRepository : IProductRepository
    {
        #region Stored Procedures
        private const string SP_GetAllProducts = "GetAllProducts";
        #endregion
        private  SqlConnection _connection;
        public ProductRepository()
        {
            _connection = Context.Connection();
        }
        public Product Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll(string search = "")
        {
            IList<Product> products = new List<Product>();
            using(SqlCommand command=new SqlCommand(SP_GetAllProducts,_connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
              var parametr=command.Parameters.Add($"@search",System.Data.SqlDbType.VarChar,100);
                parametr.Value = search;
                _connection.Open();
                var dataReader = command.ExecuteReader();
                while(dataReader.Read())
                {
                    Product product = new Product
                    {
                      ProductID=(int)dataReader[0],
                      SupplieriD=(int)dataReader[1],
                      CategoryID=(int)dataReader[2],
                      ProductName=(string)dataReader[3],
                      UnitPrice=(decimal)dataReader[4],
                      Quantity=(int)dataReader[5],
                    };
                    products.Add(product);
                }
            }
            return products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
