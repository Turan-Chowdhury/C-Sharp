using HTMLHelperDataAnnotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelperDataAnnotation.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Register()
        {
            ViewBag.Departments = GetAllDepartments();
            return View();
        }

        [HttpPost]
        public ActionResult Register(Student student)
        {
            ViewBag.Departments = GetAllDepartments();
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Departments = GetAllDepartments();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                // DB Code
            }
            ViewBag.Departments = GetAllDepartments();
            return View();

        }

        private List<Department> GetAllDepartments()
        {
            return new List<Department>()
            {
                new Department() { Id=1, Name="Computer Science & Engineering", Code="CSE" },
                new Department() { Id=2, Name="Physics", Code="PHY" },
                new Department() { Id=3, Name="Chemistry", Code="CHE" },
                new Department() { Id=4, Name="Mathematics", Code="MATH" }
            };
        }



        // Many To Many Relationshiop Model

        public ActionResult EnrollCourse()
        {
            ViewBag.Students = GetAllStudents();
            ViewBag.Courses = GetAllCourses();
            return View();
        }

        [HttpPost]
        public ActionResult EnrollCourse(StudentCourse studentCourse)
        {
            ViewBag.Students = GetAllStudents();
            ViewBag.Courses = GetAllCourses();
            return View();
        }

        private List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student() { Id=1, Name="Turan" },
                new Student() { Id=2, Name="Zia" },
                new Student() { Id=3, Name="Aziz" },
                new Student() { Id=4, Name="Tarew" }
            };
        }
        private List<Course> GetAllCourses()
        {
            return new List<Course>()
            {
                new Course() { Id=1, Title="Algorithm", Credit=2.00 },
                new Course() { Id=2, Title="Data Structure", Credit=3.00 },
                new Course() { Id=3, Title="Java", Credit=2.00 },
                new Course() { Id=4, Title="C++", Credit=3.00 },
                new Course() { Id=5, Title="Data Science", Credit=1.00 }
            };
        }

    }
}