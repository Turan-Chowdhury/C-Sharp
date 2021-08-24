using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Course : IInformation
    {
        public string Code { set; get; }
        public string Name { set; get; }
        public string Credit { set; get; }

        public string GetBasicInformation()
        {
            return "Code: " + Code + " Name: " + Name;
        }
    }
}
