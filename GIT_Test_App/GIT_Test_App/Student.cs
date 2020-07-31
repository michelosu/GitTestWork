using System;
using System.Collections.Generic;
using System.Text;

namespace GIT_Test_App
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Greetings(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            Console.WriteLine("My name is {0} - {0}", firstName, lastName);
        }

    }
}
