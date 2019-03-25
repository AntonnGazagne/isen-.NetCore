using System;

namespace isen.DotNet.Library.Persons
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth{ get; set; }

        public int? Age
        {
            get
            {
                if(!DateOfBirth.HasValue)
                    return null;
                
                var age =
                    DateTime


            }
        }


        public Person(
            string firstName,
            string LastName,
            DateTime dateOfBirth) : 
            this(firstName, LastName)
            {
                DateOfBirth = dateOfBirth;
            }
        
    }
}