using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentClassInfo = typeof(Student);

            string assemblyName = studentClassInfo.Assembly.FullName;
            Console.WriteLine(assemblyName);

            Console.WriteLine("-------------------------------------------------");

            var methods = studentClassInfo.GetMethods();
            foreach(var method in methods)
            {
                Console.WriteLine(method.ReturnType + "   " + method.Name);
            }

            Console.WriteLine("-------------------------------------------------");

            var properties = studentClassInfo.GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);
            }

            Console.WriteLine("-------------------------------------------------");

            var properties1 = studentClassInfo.GetProperties(BindingFlags.NonPublic|BindingFlags.Instance);
            foreach(var property in properties1)
            {
                Console.WriteLine(property.Name);
            }

            Console.WriteLine("-------------------------------------------------");

            var properties2 = studentClassInfo.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance|BindingFlags.Public);
            foreach (var property in properties2)
            {
                Console.WriteLine(property.Name);
            }

            Console.ReadKey();
        }
    }
}
