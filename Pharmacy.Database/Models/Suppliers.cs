using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Entity.SqlToObject
{
    public class Suppliers
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContaceName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
    }
}
