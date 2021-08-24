using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)OrderStatus.Pending);
            Console.WriteLine((int)OrderStatus.Confirmed);
            Console.WriteLine(OrderStatus.Packaging);
            Console.WriteLine((int)OrderStatus.Delivering);
            Console.WriteLine((int)OrderStatus.Received);

            Console.WriteLine();

            Console.WriteLine((int)OrderStatus2.Pending);
            Console.WriteLine((int)OrderStatus2.Confirmed);
            Console.WriteLine((int)OrderStatus2.Packaging);
            Console.WriteLine((int)OrderStatus2.Delivering);
            Console.WriteLine((int)OrderStatus2.Received);

            Console.WriteLine();

            Console.WriteLine((int)OrderStatus3.Pending);
            Console.WriteLine((int)OrderStatus3.Confirmed);
            Console.WriteLine((int)OrderStatus3.Packaging);
            Console.WriteLine((int)OrderStatus3.Delivering);
            Console.WriteLine((int)OrderStatus3.Received);

            Console.ReadKey();
        }
    }
}
