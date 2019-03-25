using System;
using isen.DotNet.Library;
using isen.DotNet.Library.Lists;
using isen.DotNet.Library.Persons;

namespace isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var jd = new Person(
                "John",
                "Doe",
                new DateTime(1964, 12, 24)
            );
            Console.WriteLine(jd);

            var unborn = new Person(
                "The",
                "Unborn"
            );
            Console.WriteLine(unborn);

            var inlinePerson = new Person()
            {
                FirstName = "Jon",
                LastName = "Appleseed",
                DateOfBirth = new DateTime(1964, 12,24)
            };
            Console.WriteLine(inlinePerson);
        }
    }
}
