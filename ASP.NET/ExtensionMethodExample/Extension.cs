using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    static class Extension
    {
        public static string GetInfo(this Person person)
        {
            return "Id:" + person.Id + "  Name:" + person.Name + "  Address:" + person.Address;
        }
    }
}
