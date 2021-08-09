using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Utitlity
{
    public class ConnectionString
    {
        private static string cName = "OZAL-PC\\SQLSERVER;Initial Catalog=StudentManagement;Integrated Security=True";
        public static string CName { get => cName;
        }
    }
}
