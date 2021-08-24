using CascadingDropdownASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingDropdownASP.NET.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            ViewBag.Departments = GetAllDepartments();
            return View();
        }
        [HttpPost]
        public ActionResult Index(int departmentId, int studentId)
        {
            ViewBag.Departments = GetAllDepartments();
            return View();
        }
        public JsonResult GetStudentsByDepartmentId(int departmentId)
        {
            var students = GetAllStudents();
            var studentList = students.Where(s => s.DepartmentId == departmentId).ToList();
            return Json(studentList);
        }
        public JsonResult GetStudentById(int id)
        {
            var students = GetAllStudents();
            var student = students.FirstOrDefault(s => s.Id == id);
            return Json(student);
        }
        private List<Department> GetAllDepartments()
        {
            return new List<Department>(){
                new Department() { Id=1, Name="CSE" },
                new Department() { Id=2, Name="EEE" },
                new Department() { Id=3, Name="ETE" }
            };
        }
        private List<Student> GetAllStudents()
        {
            return new List<Student>(){
                new Student() { Id=1, Name="Turan", DepartmentId=1 },
                new Student() { Id=2, Name="Zia", DepartmentId=3 },
                new Student() { Id=3, Name="Tareq", DepartmentId=3 },
                new Student() { Id=4, Name="Aziz", DepartmentId=1 },
                new Student() { Id=5, Name="Sharif", DepartmentId=2 },
                new Student() { Id=6, Name="Feroz", DepartmentId=3 },
            };
        }
    }
}