using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class Student : IInformation, IPrinter  // implicit Interface implementation.
    {
        public string RegNO { set; get; }
        public string Name { set; get; }
        public string Roll { set; get; }
        public string Email { set; get; }

        string IInformation.GetBasicInformation()  // Explicit Interface implementation. can only called by IInformation reference.
        {
            return "Reg No: " + RegNO + " Name: " + Name + " Roll: " + Roll;
        }
        string IPrinter.GetBasicInformation()  // Explicit Interface implementation. can only called by IPrinter reference.
        {
            return "Reg No: " + RegNO + " Name: " + Name + " Roll: " + Roll;
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void SetIpAddress()
        {
            throw new NotImplementedException();
        }

    }
}
