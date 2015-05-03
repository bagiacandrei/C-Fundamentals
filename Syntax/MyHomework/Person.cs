using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Person
    {
        protected string lastName;
        protected string firstName;
        protected DateTime dateOfBirth;
        

        public Person(string lastName, string firstName, DateTime dateOfBirth)
        {
            // TODO: Complete member initialization
            this.lastName = lastName;
            this.firstName = firstName;
            this.dateOfBirth = dateOfBirth;
        }
    }
}
