using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable dic = new Hashtable();

            dic.Add("turan", 103);
            dic.Add("zia", 203);
            dic.Add("tareq", 303);
            dic.Add("aziz", 3034);


            foreach(DictionaryEntry data in dic){
                Console.WriteLine(data.Key + "   " + data.Value);
            }

            Console.ReadKey();
        }
    }
}
