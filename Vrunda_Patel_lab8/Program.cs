using System;

namespace Vrunda_Patel_lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Section A
            #region SectioA
            Console.WriteLine("-----------SECTION A------------");
            //Create obj1 with initialization

            Person obj1 = new Person("Vrunda", "Patel", "02/10/1996", "23 monkton cr", "Brampton", "Canada");

            Console.WriteLine();
            Console.WriteLine("Display all the details of obj1");
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            obj1.DisplayInfo();

            //Create obj2 without initialization

            Person obj2 = new Person();

            Console.WriteLine();
            Console.WriteLine("Display all the details of obj2 - Before Copying");
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            obj2.DisplayInfo();

            //Performing copy

            obj1.CopyData(obj1, obj2);

            Console.WriteLine();
            Console.WriteLine("Display all the details of obj2 - After Copying");
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            obj2.DisplayInfo();
            Console.WriteLine("-----------END OF SECTION A------------");
            #endregion

            //Section B
            #region SectionB

            Console.WriteLine("-----------SECTION B------------");
            Console.WriteLine();

            //Creating an object of Student Class

            Student stu = new Student(234, new decimal[] { 10, 20, 30, 40 });

            Console.WriteLine("Overriding the DisplayInfo method in Person Class : Using DisplayInfo in Student Class");

            stu.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine("-----------END OF SECTION B------------");
            #endregion

            //Section C
            #region SectionC
            Console.WriteLine("-----------SECTION C------------");
            Console.WriteLine();

            //Creating an object of Employee Class

            Employee emp = new Employee(999, "Assistant Manager", 4500);

            Console.WriteLine("Overriding the DisplayInfo method in Person Class : Using DisplayInfo in Employee Class");

            emp.DisplayInfo();

            Console.WriteLine();
            Console.WriteLine("-----------END OF SECTION C------------");
            #endregion


            #region SectionD
            Console.WriteLine("-----------SECTION D------------");
            Console.WriteLine();

            Console.WriteLine("Creating objects of Person, Student & Employee classes");
            Person person = new Person("Vrunda", "Patel", "02/10/1996", "23 monkton cr", "Brampton", "Canada");
            Student student = new Student(111, new decimal[] { 40, 25, 75, 90 });
            Employee employee = new Employee(888, "Manager", 23000);
            Console.WriteLine();

            Console.WriteLine("DisplayInfo of : Person Class");
            Console.WriteLine();
            person.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("DisplayInfo of : Student Class");
            Console.WriteLine();
            student.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("DisplayInfo of : Employee Class");
            Console.WriteLine();
            employee.DisplayInfo();
            Console.WriteLine();


            //Assign student oject to person
            Console.WriteLine("Assigning student object to person");
            person = student;
            Console.WriteLine("Calling DisplayInfo using person object");

            Console.WriteLine("DisplayInfo of : Person Class after copying student oject");
            Console.WriteLine();
            person.DisplayInfo();
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine("-----------END OF SECTION D------------");
            #endregion

        }
    }
}
    
