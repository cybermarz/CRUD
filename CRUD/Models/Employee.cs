using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mobilename { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
