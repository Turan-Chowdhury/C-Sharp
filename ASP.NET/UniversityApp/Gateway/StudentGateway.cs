using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UniversityApp.Models;

namespace UniversityApp.Gateway
{
    public class StudentGateway
    {
        ConnectionDb connection = new ConnectionDb();
        public int SaveStudent(Student student)
        {            
            string query = "INSERT INTO Students(Name, RegNo, Email, Address, Department) VALUES('" + student.Name + "', '" + student.RegNo + "', '" + student.Email + "', '" + student.Address + "', '" + student.Department + "')";
            SqlCommand command = new SqlCommand(query, connection.GetConnectionAndOpen());
            int rowAffected = command.ExecuteNonQuery();
            connection.GetClose();
            return rowAffected;
        }

        public bool IsRegNoExist(string regNO)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QC16PG4\SQLEXPRESS;Initial Catalog=UniversityDb;Integrated Security=True;MultipleActiveResultSets=True");
            connection.Open();
            string query = "SELECT * FROM Students WHERE RegNO ='" + regNO + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            connection.Close();
            return isExist;
        }

        public List<Student> GetAllStudents()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QC16PG4\SQLEXPRESS;Initial Catalog=UniversityDb;Integrated Security=True;MultipleActiveResultSets=True");
            connection.Open();
            string query = "SELECT * FROM Students";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student student = new Student();
                student.Id = (int)reader["Id"];
                student.Name = reader["Name"].ToString();
                student.RegNo = reader["RegNo"].ToString();
                student.Email = reader["Email"].ToString();
                student.Address = reader["Address"].ToString();
                student.Department = reader["Department"].ToString();

                students.Add(student);
            }
            connection.Close();
            return students;
        }

        public Student SearchStudentByRegNo(string regNO)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QC16PG4\SQLEXPRESS;Initial Catalog=UniversityDb;Integrated Security=True;MultipleActiveResultSets=True");
            connection.Open();
            string query = "SELECT * FROM Students WHERE RegNO ='" + regNO + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            Student student = new Student();
            while (reader.Read())
            {                
                student.Id = (int)reader["Id"];
                student.Name = reader["Name"].ToString();
                student.RegNo = reader["RegNo"].ToString();
                student.Email = reader["Email"].ToString();
                student.Address = reader["Address"].ToString();
                student.Department = reader["Department"].ToString();
            }
            connection.Close();
            return student;
        }

        public int DeleteStudent(string regNO)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QC16PG4\SQLEXPRESS;Initial Catalog=UniversityDb;Integrated Security=True;MultipleActiveResultSets=True");
            connection.Open();
            string query = "DELETE FROM Students WHERE RegNO ='" + regNO + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            int rowCount = command.ExecuteNonQuery();
            connection.Close();
            return rowCount;
        }

        public int UpdateStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QC16PG4\SQLEXPRESS;Initial Catalog=UniversityDb;Integrated Security=True;MultipleActiveResultSets=True");
            connection.Open();
            string query = "UPDATE Students SET Name='"+ student.Name + "', Email='" + student.Email + "', Address='" + student.Address + "', Department='" + student.Department + "' WHERE RegNO ='" + student.RegNo + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            int rowCount = command.ExecuteNonQuery();
            connection.Close();
            return rowCount;
        }
    }
}