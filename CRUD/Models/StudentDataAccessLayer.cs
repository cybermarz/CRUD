using CRUD.Models;
using CRUD.Utitlity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class StudentDataAccessLayer
    {
        string connectionString = ConnectionString.CName;
        public IEnumerable<StudentViewModel> Read()
        {
            List<StudentViewModel> lstStudent = new List<StudentViewModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spRead", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    StudentViewModel student = new StudentViewModel();
                    student.Id = Convert.ToInt32(rdr["Id"]);
                    student.FirstName = rdr["FirstName"].ToString();
                    student.LastName = rdr["LastName"].ToString();
                    student.Email = rdr["Email"].ToString();
                    student.Mobile = rdr["Mobile"].ToString();
                    student.Addresss = rdr["Adresss"].ToString();

                    lstStudent.Add(student);
                }
                con.Close();
            }
            return lstStudent;
        }

    }
}
