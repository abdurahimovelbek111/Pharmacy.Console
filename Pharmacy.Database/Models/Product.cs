using Pharm.Entity.SqlToObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Entity.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public int SupplieriD { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
