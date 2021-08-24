using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityApp.Gateway;
using UniversityApp.Models;

namespace UniversityApp.Manager
{
    public class StudentManager
    {
        StudentGateway studentGateway = new StudentGateway();
        public string SaveStudent(Student student)
        {
            if (studentGateway.IsRegNoExist(student.RegNo))
            {
                return "Reg No. Already Exist";
            }
            int rowAffected = studentGateway.SaveStudent(student);
            if (rowAffected > 0)
            {
                return "Data Inserted Successfully";
            }
            return "Data Insert Failed";
        }

        public List<Student> GetAllStudents()
        {
            return studentGateway.GetAllStudents();
        }

        public Student SearchStudentByRegNo(string regNO)
        {           
            return studentGateway.SearchStudentByRegNo(regNO);
        }

        public string DeleteStudent(string regNo)
        {
            int rowCount = studentGateway.DeleteStudent(regNo);
            if (rowCount > 0)
            {
                return "Student Deleted Successfully";
            }
            return "Delete Failed";
        }

        public string UpdateStudent(Student student)
        {
            int rowCount = studentGateway.UpdateStudent(student);
            if (rowCount > 0)
            {
                return "Student info has been updated";
            }
            return "Update Failed";
        }
    }
}