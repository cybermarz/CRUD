using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Utitlity
{
    public class ConnectionString
    {
        private static string cName = "Data Source=.; Initial Catalog=StudentManagement; User ID=ozal; Password=12345";
        public static string CName { get => cName;
        }
    }
}
