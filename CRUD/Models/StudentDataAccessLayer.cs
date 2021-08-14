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

        /*Create*/
        public void AddStudent(StudentViewModel student)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spCreate", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@Mobile", student.Mobile);
                cmd.Parameters.AddWithValue("@Addresss", student.Addresss);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        /*Read*/
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
                    student.Addresss = rdr["Addresss"].ToString();

                    lstStudent.Add(student);
                }
                con.Close();
            }
            return lstStudent;
        }
        
        /*Update*/
        public void UpdateStudent(StudentViewModel student)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", student.Id);
                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@Mobile", student.Mobile);
                cmd.Parameters.AddWithValue("@Addresss", student.Addresss);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        
        /*Delete*/
        public void DeleteStudent(int? Id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        /*Show*/
        public StudentViewModel GetStudent(int? Id)
        {
            StudentViewModel student = new StudentViewModel();
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlquery = 
                    "SELECT * FROM Student WHERE Id= " + Id;
                SqlCommand cmd = new SqlCommand(sqlquery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    student.Id = Convert.ToInt32(rdr["Id"]);
                    student.FirstName = rdr["FirstName"].ToString();
                    student.LastName = rdr["LastName"].ToString();
                    student.Email = rdr["Email"].ToString();
                    student.Mobile = rdr["Mobile"].ToString();
                    student.Addresss = rdr["Addresss"].ToString();
                }
                con.Close();
            }
            return student;
        }
    }
}
