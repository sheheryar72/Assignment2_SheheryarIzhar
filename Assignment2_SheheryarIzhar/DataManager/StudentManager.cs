using Assignment2_SheheryarIzhar.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Assignment2_SheheryarIzhar.DataManager
{
    public class StudentManager
    {   
        string _connectionString = "Data Source=192.168.20.166;Initial Catalog=StudentRecords;User ID=tech; Password=tech;Integrated Security=false;";
        public List<Student> GetAllStudent()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select * from Student";
                conn.Open();
                var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                if(dt != null && dt.Rows.Count > 0)
                {
                    List<Student> st = new List<Student>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var student = new Student();
                        student.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                        student.Name = dt.Rows[i]["Name"].ToString();
                        student.Age = Convert.ToInt32(dt.Rows[i]["Age"]);
                        st.Add(student);
                    }
                    conn.Close();
                    return st;
                }
                return null;
            }   
        }
        public Student GetStudentById(int Id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select * from Student Where Id = @id";
                cmd.Parameters.AddWithValue("@Id", Id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt != null && dt.Rows.Count > 0)
                {
                    var student = new Student();
                    student.Name = dt.Rows[0]["Name"].ToString();
                    student.Age = Convert.ToInt32(dt.Rows[0]["Age"]);
                    return student;
                }
                return null;
            }
        }
        public string AddStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Insert into Student (Name, Age) values (@Name, @Age)";
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                conn.Open();
                int rawAffected = cmd.ExecuteNonQuery();

                if(rawAffected > 0)
                {
                    return student.Name;
                    conn.Close();
                }
                return null;
            }
        }
        public string EditStudent(Student student)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Update Student Set Name = @Name, Age = @Age where Id = @Id";
                cmd.Parameters.AddWithValue("@Id", student.Id);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                conn.Open();
                int rawAffected = cmd.ExecuteNonQuery();

                if (rawAffected > 0)
                {
                    return student.Name;
                    conn.Close();
                }
                return null;
            }
        }
    }
}
