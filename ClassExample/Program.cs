using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Md.", "Tarekul", "Islam");
            Console.WriteLine(person1.getFullName());
            Console.ReadKey();
        }
    }
}
