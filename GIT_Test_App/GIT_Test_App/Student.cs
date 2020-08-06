using System;
using System.Collections.Generic;
using System.Text;

namespace GIT_Test_App
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Address { get; set; }

        public void Greetings(string firstName, string lastName, string nickName, string address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.NickName = nickName;
            this.Address = address;

            Console.WriteLine("My name is {0} - {1}, and my nick name is: {2} and I am living on the {3} street", firstName, lastName, nickName, address);
        }

    }
}
