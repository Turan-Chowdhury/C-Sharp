using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student<int> student1 = new Student<int>() { Name = "turan", Success = 1 };
            Student<bool> student2 = new Student<bool>() { Name = "turan", Success = true };
            Student<string> student3 = new Student<string>() { Name = "turan", Success = "pass" };

            Print(student1);
            Print(student2);
            Print(student3);

            Console.ReadKey();
        }

        public static void Print<T>(Student<T> student)
        {
            Console.WriteLine("Name: " + student.Name + "     Success: " + student.Success);
        }
    }

    class Student<T>
    {
        public string Name { set; get; }
        public T Success { set; get; }
    }
}
