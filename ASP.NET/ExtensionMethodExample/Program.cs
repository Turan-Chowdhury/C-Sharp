using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Id = 01;
            person.Name = "Turan";
            person.Address = "Dhaka";

            string info = person.GetInfo(); // Extension method
            Console.WriteLine(info);

            Console.ReadKey();
        }
    }
}
