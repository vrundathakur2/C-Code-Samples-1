using System;
using System.Collections.Generic;
using System.Text;

namespace Vrunda_Patel_lab8
{
    class Person
    {
        public class Person
        {

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string DateofBirth { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
        }

            

            public Person(string firstName, string lastName, string dateOfBirth, string Address, string city, string country)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.DateofBirth = dateOfBirth;
                this.Address = Address;
                this.City = city;
                this.Country = country;
            }

            public void DisplayInfo()
            {
                Console.WriteLine("First Name: {0}", this.FirstName);
                Console.WriteLine("Last Name: {0}", this.LastName);
                Console.WriteLine("Date of Birth: {0}", this.DateofBirth);
                Console.WriteLine("Address: {0}", this.Address);
                Console.WriteLine("City: {0}", this.City);
                Console.WriteLine("Country: {0}", this.Country);
            }

            public void CopyData(Person fromObject, Person toObject)
            {
                //Copying dat from fromObject to toObject
                toObject.FirstName = fromObject.FirstName;
                toObject.LastName = fromObject.LastName;
                toObject.DateofBirth = fromObject.DateofBirth;
                toObject.Address = fromObject.Address;
                toObject.City = fromObject.City;
                toObject.Country = fromObject.Country;

            }
        }
    }

}

