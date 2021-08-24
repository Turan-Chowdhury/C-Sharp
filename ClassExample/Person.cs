using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Person
    {
        public string id;
        public string firstName;
        public string middleName;
        public string lastName;

        /*
        private string firstName;

        public string FirstName                            PROPERTY
        {
            set { firstName = value;  }
            get { return firstName; }
        }
        */


        //public string FirstName { get; set; }            AUTO PROPERTY
        

        public Person(string firstName, string middleName, string lastName) : this(firstName, lastName) // Chaining
        {
            this.middleName = middleName;
        }

        public Person(string firstName, string lastName) : this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person()
        {
            id = "0000";
        }

        public string getFullName()
        {
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }
    }
}
