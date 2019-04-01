using System;
using isen.DotNet.Library;
using isen.DotNet.Library.Lists;
using isen.DotNet.Library.Models;

namespace isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var toulon = new City()
            {
                Id = 1,
                Name = "Toulon",
                ZipCode = "83000"
            };
            Console.WriteLine(toulon);
            var nice = new City()
            {
                Id = 2,
                Name = "Nice",
                ZipCode = "86000"
            };
            Console.WriteLine(nice);

            var jd = new Person()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1964, 12, 24),
                BornIn = toulon
            };
            Console.WriteLine(jd);


            var inlinePerson = new Person()
            {
                Id = 2,
                FirstName = "Jon",
                LastName = "Appleseed",
                DateOfBirth = new DateTime(1964, 12,24),
                BornIn = nice
            };
            Console.WriteLine(inlinePerson);
        }
    }
}
