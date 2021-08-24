using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationRelationshipDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address();
            address1.AptNo = "7A";
            address1.HouseNo = "34";
            address1.RoadNo = "01";
            address1.Thana = "Khulshi";
            address1.District = "Ctg";

            Student student1 = new Student();
            student1.RegNO = "7823";
            student1.Name = "Turan";
            student1.Email = "turan@gmail.com";
            student1.StudentAddress = address1;

            string houseNo = student1.StudentAddress.HouseNo;
            string thana = student1.StudentAddress.Thana;
            Console.WriteLine(houseNo);
            Console.WriteLine(thana);
            Console.WriteLine();

            Student student2 = new Student();
            student2.RegNO = "7843";
            student2.Name = "Monir";
            student2.Email = "monir@gmail.com";
            student2.StudentAddress = address1;

            Student student3 = new Student();
            student3.RegNO = "7865";
            student3.Name = "zia";
            student3.Email = "zia@gmail.com";
            student3.StudentAddress = address1;

            Department dept1 = new Department();
            dept1.ShortName = "cse";
            dept1.FullName = "computer Science & Engineering";
            dept1.Students.Add(student1);
            dept1.Students.Add(student2);
            dept1.Students.Add(student3);

            foreach(Student student in dept1.Students)
            {
                string info = student.Name + "    " + student.Email + "    " + student.RegNO;
                Console.WriteLine(info);
            }
            Console.WriteLine();

            student1.PhysicsScore = 45;
            student1.MathScore = 34;
            Console.WriteLine(student1.GetResult());

            Console.ReadKey();
        }
    }
}
