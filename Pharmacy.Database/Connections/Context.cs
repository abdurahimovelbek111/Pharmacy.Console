using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Pharmacy.Database.Connections
{
    public class Context
    {
        private const string CONNECTION_STRING = @"Server=DESKTOP-HUC7BS4;Database=Dorixona";
        public static SqlConnection Connection() => new SqlConnection(CONNECTION_STRING);
    }   
}
