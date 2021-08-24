using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{    
    class Program
    {
        public delegate int CalculatorHandler(int firstNumber, int secondNumber);  // delegat declare  // Single Delegates
        public delegate void PrintHandler(string name); // Multicast Delegates
        public delegate void Print<T>(T param);  // Generic Delegate
        //public delegate T Print<T, F>(T param1, F param2);  
        static void Main(string[] args)
        {
            // Single Delegates

            CalculatorHandler calculatorHandler = Add;  // set a target method
            //CalculatorHandler calculatorHandler = new CalculatorHandler(add);

            int result = calculatorHandler.Invoke(10, 20);  // invoke delegate
            //int result = calculatorHandler(10, 20);
            Console.WriteLine(result);

            CalculatorHandler calculatorHandler1 = Sub;

            InvokeDelegates(calculatorHandler, 20, 10);  // pass Add method as parameter
            InvokeDelegates(calculatorHandler1, 20, 10);  // pass Sub method as parameter

            CalculatorHandler calculatorHandler2 = delegate (int firstNumbet, int secondNumber)   // anonymous method
                                                    {
                                                        return firstNumbet * secondNumber;
                                                    };

            CalculatorHandler calculatorHandler3 = 
                (firstNumber, secondNumber) => firstNumber / secondNumber;  // lambda expression

            CalculatorHandler calculatorHandler4 =
                (firstNumber, secondNumber) =>                   // lambda statement
                {
                    return firstNumber / secondNumber;
                };

            InvokeDelegates(calculatorHandler2, 20, 10);
            InvokeDelegates(calculatorHandler3, 20, 10);

            Console.WriteLine("--------------");


            // Multicast Delegates

            PrintHandler printHandler = Hello;
            printHandler += GoodBye;
            //printHandler -= GoodBye;

            printHandler("Turan");

            /*
            PrintHandler printHandler = Hello;
            PrintHandler printHandler1 = GoodBye;
            PrintHandler printHandler2 = printHandler + printHandler1;

            printHandler2 -= printHandler;
            */


            // Generic Delegate

            Print<string> print = Hello;
            Print<string> print1 = GoodBye;
            Print<int> print2 = Test;

            Console.WriteLine("--------------");


            // Built In Delegates

            Func<int, int, int> func = Add;   // method must return an output
            Action<string> action = Hello;    // method must not return an output

            Predicate<string> nameSearch = CheckName; // method must take one input and return a boolean output

            List<string> names = new List<string>() { "turan", "md. asiful", "tareq", "md. shahim" };
            var data = names.FindAll(nameSearch);

            foreach(var item in data)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }

        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        static void InvokeDelegates(CalculatorHandler calculatorHandler, int fNumber, int sNumber)
        {
            int result = calculatorHandler.Invoke(fNumber, sNumber);
            Console.WriteLine(result);
        }

        static void Hello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static void GoodBye(string name)
        {
            Console.WriteLine("Good Bye " + name);
        }

        static void Test(int n)
        {
            Console.WriteLine(n);
        }

        static bool CheckName(string name)
        {
            if(name.StartsWith("md. "))
            {
                return true;
            }
            return false;
        }
    }    
}
