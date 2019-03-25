using System;

namespace isen.DotNet.Library.Persons
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth{ get; set; }

        public Person(
            string firstName,
            string LastName,
            DateTime DateOfBirth) : 
            this(firstName, LastName)
            {
                DateOfBirth = DateOfBirth
            }
        )
    }
}