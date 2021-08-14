using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Utitlity
{
    public class ConnectionString
    {
        //private static string cName = "OZAL-PC\\SQLSERVER;Initial_Catalog=StudentManagement;Integrated Security=True;";

        private static string cName = "Server=OZAL-PC\\SQLSERVER;Database=StudentManagement;Trusted_Connection=True;";
        public static string CName { get => cName;
        }
    }
}
