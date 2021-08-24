using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Model;

namespace UniversityManagementSystem.Gateway
{
    class StudentGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["UniversiryDbConString"].ConnectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string query;
        public StudentGateway()
        {
            connection = new SqlConnection(connectionString);
        }
        public int SaveStudent(Student aStudent)
        {
            connection.Open();
            query = "INSERT INTO Students(Name, RegNo, PhoneNo, Email, DepartmentId) VALUES(@Name, @RegNo, @PhoneNo, @Email, @DepartmentId)";
            command = new SqlCommand(query, connection);
            command.Parameters.Clear();

            //command.Parameters.Add("Name", SqlDbType.NVarChar);
            //command.Parameters["Name"].Value = aStudent.Name;
            //command.Parameters.Add("RegNo", SqlDbType.NVarChar);
            //command.Parameters["RegNo"].Value = aStudent.RegNO;
            //command.Parameters.Add("PhoneNo", SqlDbType.NVarChar);
            //command.Parameters["PhoneNo"].Value = aStudent.PhoneNO;
            //command.Parameters.Add("Email", SqlDbType.NVarChar);
            //command.Parameters["Email"].Value = aStudent.Email;
            //command.Parameters.Add("DepartmentId", SqlDbType.Int);
            //command.Parameters["DepartmentId"].Value = aStudent.DepartmentId;

            command.Parameters.AddWithValue("Name", aStudent.Name);
            command.Parameters.AddWithValue("RegNo", aStudent.RegNO);
            command.Parameters.AddWithValue("PhoneNo", aStudent.PhoneNO);
            command.Parameters.AddWithValue("Email", aStudent.Email);
            command.Parameters.AddWithValue("DepartmentId", aStudent.DepartmentId);

            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
        public bool isRegNoExist(Student student)
        {
            query = "SELECT * FROM Students WHERE RegNO ='"+student.RegNO+"' AND Id <> '"+student.Id+"' ";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            connection.Close();
            return isExist;
        }
        public List<StudentWithDept> getAllStudents()
        {
            query = "SELECT * FROM StudentWithDept";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<StudentWithDept> students = new List<StudentWithDept>();
            while (reader.Read())
            {
                StudentWithDept studentWithDept = new StudentWithDept();
                studentWithDept.StudentId = Convert.ToInt32(reader["StudentId"]);
                studentWithDept.StudentName = reader["StudentName"].ToString();
                studentWithDept.RegNO = reader["RegNo"].ToString();
                studentWithDept.PhoneNO = reader["PhoneNo"].ToString();
                studentWithDept.Email = reader["Email"].ToString();
                studentWithDept.DeptId = (int)reader["DeptId"];
                studentWithDept.Code = reader["Code"].ToString();
                studentWithDept.DeptName = reader["DeptName"].ToString();

                students.Add(studentWithDept);
            }
            reader.Close();
            connection.Close();
            return students;
        }
        public int UpdateStudent(Student student)
        {
            query = " UPDATE Students SET Name='" + student.Name + "', RegNo='" + student.RegNO + "', PhoneNo='" + student.PhoneNO + "', Email='" + student.Email + "', DepartmentId='" + student.DepartmentId + "' WHERE Id='" + student.Id + "' ";
            command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
        public int DeleteStudent(int id)
        {
            query = "DELETE FROM Students WHERE Id='" + id + "' ";
            command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
    }
}
