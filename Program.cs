using System;
namespace Namespace
{
    internal class Programm
    {
        static void Main(string[] Args)
        {
            var p = new Person() { FirstName = "Vincent", LastName = "De Vries", Birthday = new DateTime(2007, 11, 23) };
            Console.ReadLine();
        }
    }
    class Person
    {
        public string LastName;
        public string FirstName;
        public DateTime Birthday;
    }
}
