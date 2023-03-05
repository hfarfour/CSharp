using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions; //for exceptions

namespace Throw_Exception
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("======= throwing Exception ========");
            //    Student std = null;
            //    try
            //    {
            //        PrintStudentName(std);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }





            Console.WriteLine("======= Re-throwing an Exception ========");
            //You can also re-throw an exception from the catch block to pass on to the caller and
            //let the caller handle it the way they want.
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }





            Console.WriteLine("======== Custom Exception =========");
            //if the name contains special characters or numbers
            try
            {
                Student newStudent = new Student();
                newStudent.StudentName = "Jame34";

                ValidateStudent(newStudent);
            }
            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //throw exception
        public static void PrintStudentName(Student std)
        {
            if (std == null)
                throw new NullReferenceException("Student object is null. ");
            Console.WriteLine(std.StudentName);
        }

        //re-throw wxception
        public static void Method1()
        {
            try
            {
                Method2();
            }
            catch (NullReferenceException ex)
            {
                throw ex ;
            }
        }
        //re-throw exception
        public static void Method2()
        {
            string str = "";
            try
            {
                Console.Write(str[0]);
            }
            catch (NullReferenceException ex)
            {
                throw;
            }
        }

        //Custom Exception
        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);
            else
                Console.WriteLine(std.StudentName);
        }

    }


    public class Student
    {
        public string StudentName { get; set; }
        public int StudentID { get; set; }
    }
        //Custom Exception
    [Serializable]
    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() { }

        public InvalidStudentNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {

        }
    }
}
