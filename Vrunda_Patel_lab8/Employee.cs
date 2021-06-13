using System;
using System.Collections.Generic;
using System.Text;

namespace Vrunda_Patel_lab8
{
    public class Employee : Person
    {
        //        1.	Create an employee class which will inherit from Person class.
        //2.	Add two additional data member to student class: EmployeeId, Title, Salary.
        //3.	Create parameterized constructor to initial all the data members including person class members.
        //4.	Override the DisplayInfo method to display additional information.

        public int EmployeeID { get; set; }
        public string Title { get; set; }
        public decimal Salary { get; set; }


        public Employee(int employeeID, string title, decimal salary) : base("Ishara", "Senanayake", "25/09/1990", "33 Kandy Road", "Yakkala", "Sri Lanka")
        {
            this.EmployeeID = employeeID;
            this.Title = title;
            this.Salary = salary;
        }

        public new void DisplayInfo()
        {
            Console.WriteLine("First Name: {0}", this.FirstName);
            Console.WriteLine("Last Name: {0}", this.LastName);
            Console.WriteLine("Date of Birth: {0}", this.DateofBirth);
            Console.WriteLine("Address: {0}", this.Address);
            Console.WriteLine("City: {0}", this.City);
            Console.WriteLine("Country: {0}", this.Country);
            Console.WriteLine("Employee ID: {0}", this.EmployeeID);
            Console.WriteLine("Title: {0}", this.Title);
            Console.WriteLine("Salary: {0}", this.Salary);

        }
    }
}

