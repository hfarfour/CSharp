using System;
using System.Collections.Generic;
using static System.String;
// a new way to initialize an object of a class or collection.
//Object initializers allow you to assign values to the fields or properties
//at the time of creating an object without invoking a constructor.

namespace Object_Initializer
{
    class Program
    {
        static void Main()
        {
            var student1 = new Student() { StudentID = 1, StudentName = "John" };
            var student2 = new Student() { StudentID = 2, StudentName = "Steve" };
            var student3 = new Student() { StudentID = 3, StudentName = "Bill" };
            var student4 = new Student() { StudentID = 3, StudentName = "Bill" };
            var student5 = new Student() { StudentID = 5, StudentName = "Ron" };

            IList<Student> studentList = new List<Student>()
            {
               student1,
               student2,
               student3,
               student4,
               student5
            };

            Console.WriteLine("Total Students: {0}", studentList.Count);
            Console.WriteLine(" Students 1: {0}", student1.StudentName);
            Console.WriteLine("");
            //You can also initialize collections and objects at the same time.
            IList<Student> studentLists = new List<Student>() 
            {
                    new Student() { StudentID = 1, StudentName = "John" } ,
                    new Student() { StudentID = 2, StudentName = "Steve" } ,
                    new Student() { StudentID = 3, StudentName = "Bill" } ,
                    new Student() { StudentID = 4, StudentName = "Bill" } ,
                    new Student() { StudentID = 5, StudentName = "Ram" } ,
                    new Student() { StudentID = 6, StudentName = "Ron" }
             };

            Console.WriteLine("Total Students: {0}", studentLists.Count);
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }

    }
}

