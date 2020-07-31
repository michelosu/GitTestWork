using System;

namespace GIT_Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is a test to play with GIT");

            Student std = new Student();
            std.Greetings("Mihai","Anghel");

            Console.WriteLine();
        }
    }
}
