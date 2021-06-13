# C-Code-Samples-1
Types of Constructors,Method Overriding,Inheritance


Section A:
1.	Create Person Class with following data fields.
•	FirstName
•	LastName
•	DateOfBirth
•	Address
•	City
•	Country
2.	Create properties for each data member.
3.	Create default and parameterized constructor to initialize all the data members.
4.	Create data method named DisplayInfo, which will display all the data fields to user.
5.	Create a copy_Data data method which will take two object of person as parameter. It will perform copy of all the data members from one object to other. 
6.	In Main method do following:
a.	Create a person class object obj1 with initialization.
b.	Use display object to print all the information.
c.	Create another person object obj2 without initialization.
d.	Call copy_Data method to copy obj1 to obj2.
e.	Display information before and after the copy.


Section B:
1.	Create a student class which will inherit from Person class.
2.	Add two additional data member to student class: StudentId, Grade array.
3.	Create parameterized constructor to initial all the data members including person class members.
4.	Override the DisplayInfo method to display additional information.


Section C:
1.	Create an employee class which will inherit from Person class.
2.	Add two additional data member to student class: EmployeeId, Title,Salary.
3.	Create parameterized constructor to initial all the data members including person class members.
4.	Override the DisplayInfo method to display additional information.


Section D:
In Main method do following
1.	Create object of Person using Initialization
2.	Create object of Student using Initialization
3.	Create Object of Employee using Initialization
4.	Use displayInfo for all the three objects. 
5.	Assign Student object to Person
6.	Call displayInfo using Person object.




