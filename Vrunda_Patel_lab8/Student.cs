using System;
using System.Collections.Generic;
using System.Text;

namespace Vrunda_Patel_lab8
{
    public class Student : Person
    {
        //        1.	Create a student class which will inherit from Person class.
        //2.	Add two additional data member to student class: StudentId, Grade array.
        //3.	Create parameterized constructor to initial all the data members including person class members.
        //4.	Override the DisplayInfo method to display additional information.

        public int StudentID { get; set; }
        public decimal[] Grade { get; set; }

        public Student(int studentID, decimal[] grade) : base("Andrew", "Mattison", "22/08/1987", "100 Pine Grove", "New York", "USA")
        {
            this.StudentID = studentID;
            this.Grade = grade;
        }

        public new void DisplayInfo()
        {
            Console.WriteLine("First Name: {0}", this.FirstName);
            Console.WriteLine("Last Name: {0}", this.LastName);
            Console.WriteLine("Date of Birth: {0}", this.DateofBirth);
            Console.WriteLine("Address: {0}", this.Address);
            Console.WriteLine("City: {0}", this.City);
            Console.WriteLine("Country: {0}", this.Country);
            Console.WriteLine("Student ID: {0}", this.StudentID);
            Console.WriteLine("Grades: ");

            foreach (var item in this.Grade)
            {
                Console.Write(item.ToString() + " ");
            }
        }
    }
}


