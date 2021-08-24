using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkingWithView.Models;

namespace WorkingWithView.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult HelloWorld()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Name = "Turan", RegNo = "123-435", AgeInYear = "30" },
                new Student() { Name = "zia", RegNo = "123-5345", AgeInYear = "32" },
                new Student() { Name = "tareq", RegNo = "123-6436", AgeInYear = "33" }

            };

            //ViewBag.StudentList = students;

            //Student student = new Student() { Name = "Turan", RegNo = "123-435", AgeInYear = "30" };

            return View(students);
        }
    }
}