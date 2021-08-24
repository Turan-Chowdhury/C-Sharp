using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Gateway;
using UniversityManagementSystem.Model;

namespace UniversityManagementSystem.Manager
{
    class StudentManager
    {
        private StudentGateway aStudentGateway = new StudentGateway();
        public string SaveStudent(Student aStudent)
        {
            if (aStudentGateway.isRegNoExist(aStudent))
            {
                return "Registration number already exists.";
            }
            int rowAffected = aStudentGateway.SaveStudent(aStudent);
            if (rowAffected > 0)
            {
                return "Saved Successfully";
            }
            return "Saved Failed"; 
        }
        public List<StudentWithDept> getAllStudents()
        {
            return aStudentGateway.getAllStudents();
        }
        public string UpdateStudent(Student student)
        {
            if (aStudentGateway.isRegNoExist(student))
            {
                return "Registration number already exists.";
            }
            int rowAffected = aStudentGateway.UpdateStudent(student);
            if(rowAffected > 0)
            {
                return "Updated successfully";
            }
            return "Saved Failed";
        }
        public string DeleteStudent(int id)
        {
            int rowAffected = aStudentGateway.DeleteStudent(id);
            if (rowAffected > 0)
            {
                return "Removed successfully";
            }
            return "Failed to delete";
        }
    }
}
