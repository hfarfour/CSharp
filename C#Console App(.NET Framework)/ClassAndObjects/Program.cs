using System;
using static System.String;
using School; // to access namespace 
using School.Education;

// a class is like a buleprint of a specific object that has certain attributes and feartures.
// likewise in OOP a class defines some properties.fields,eventsm methods etc.A class defines the 
// kinds of data and the functionality their object will have;

//A class can contain one or more constructors, methods, properties,delegates,and events,
//They are called class members.

//A class and its members can have access modifiers such as public, private, protected, and internal,
//to restrict access from other parts of the program.

//You have to allocate a class with "new" because of those three things on the list.
//You need new memory allocated from the long-term storage and you need to pass a reference to that storage to the constructor.
//"new" is the operator that knows how to do that.


namespace ClassAndObjects
{
    class Program
    {
        static void Main()
        {
            //Student student1 = new Student()
            //{
            //    FistName = "Hossam",
            //    LastName = "Farfour",
            //    StudentID = 12345,
            //};
            //or
            Student student1 = new Student();
            student1.FistName = "Issa";
            student1.LastName = "Farfour";
            student1.StudentID = 13455;

            Console.WriteLine(student1.getFullNmae());
            Console.WriteLine(student1.StudentID);
            int num1 = 12;
            int num2 = 12;
            Console.WriteLine(student1.Sum(num1,num2));


            // School namespace
            School.student std = new School.student();
            School.course co = new School.course();
            // to avoid full declration i can add using School at the top
            // Like
            student std1 = new student();
            course co1 = new course();

            StudentsList list = new StudentsList();
        }
        //end main======================================================

        class Student
        {
            // constructor
            public Student()
            {
                Console.WriteLine("this is constructor");
            }
            private int ID; // this is field
            public int StudentID // this is property to assign and retrieve underlying field value. 
            {
                get { return ID; }
                set { if(value > 0)
                        ID = value;
                }
            }
            //Using auto-implemented property, you don't need to declare an underlying private field.
            //C# compiler will automatically create it in IL code
            public string FistName {get; set;}
            public string LastName {get; set;}

            // meoth to get full nme
            public string getFullNmae()
            {
                return FistName + " " + LastName;
            }


            // this is method
            //A method can contain one or more statements to be executed as a single unit.
            public int Sum(int num1, int num2)
            {
                var total = num1 + num2;
                return total;
            }
        }
    }

}

// nacespace 
///A namespace is a container for classes and namespaces.
///Student class can be accessed as School.Student.
namespace School
{
    
    class student
    {

    }
    class course
    {

    }
}
//A namespace can contain other namespaces.Inner namespaces can be separated using (.).

namespace School.Education
{
    class StudentsList
    {

    }
}