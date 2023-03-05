using System;
using static System.String;


// ascape type checking at compile time instead it resolves type at run time (dynamic)
// A readonly field can be initialize either reun time or in the constructor. 
namespace ConsoleApp1
{
    class Program // by defalut is Internall not public
    {
        static void Main()
        {
            int num = 100;
            char code = 'C';
            bool isValid = true;
            string meaasge = "Hello world"; // vlaue of variable

            //method to display value on consle
            Console.WriteLine(num);  
            Console.WriteLine(code);
            Console.WriteLine(isValid);
            Console.WriteLine(meaasge);

            //create an instance of class 
            Employee emp1 = new Employee();
            Console.WriteLine(emp1.salary); // result is 0 because Static variabls and 
              // instance variables and array elemnets are automatically initialized to their 
             // default values 0;
             // == similar example== 
            int[] array = new int[5];
            Console.WriteLine(array[0]);

            // call method display
            int k = 20;
            display(k);

            // variable to null
            // var str = null; // can nnot assign null to var; because it can not decide the type.
            // Console.WriteLine(str);

            //the ReferenceEquals() method check whether the two object point to the same object 
            //in the memeory or not, here great two objects
            object x = "Hi";
            object y = 3;
           Console.WriteLine( object.ReferenceEquals(x, y)); //print false

            // point to the same memory So the compiler great only one object
            string str1, str2;
            str1 = "Hello";
            str2 = "Hello";
            Console.WriteLine(object.ReferenceEquals(str1, str2));  // print true

            //The string.Copy() return a new object with the same value So point to two diffrent memory location
            string str3 = "Hi";
            string str4 = string.Copy(str3);
            Console.WriteLine(object.ReferenceEquals(str3, str4)); // print false

            // print method
            for (int i = 0; i < 2; i++)
                Printer.print(i);


            // test
            test();


            // class Person toString()
            Person p = new Person()
            {
                FirstName = "Hossam",
                LastName = "Farfour"
            };
            Console.WriteLine(p.ToString());



            // using static System.String  is included and so all the static
            //methods of String class can be called without the class name String.
            string str6 = null;
            Console.WriteLine(IsNullOrEmpty(str6));
            Console.ReadKey();
        }

        // end main () =========================================================
        class Employee 
        {
            public int salary; // it private by defalut
        }


        static void display(int val)
        {
            Console.WriteLine(val);
        }


        static class Printer
        {
            static Printer()
            {
                Console.WriteLine("constructor");
            }
            public static void print(object o)
            {
                Console.WriteLine(o);
            }
        }

       static void test ()
        {
            Console.WriteLine("testing()");
        }


        class Person
        {
            public string FirstName{get; set;}// Auto implemented property is defined wiht{get; set;}
            public string LastName{get; set;}
            public override string ToString() => $"{FirstName} {LastName}";
            //ToString() is called Expression-bodied function which consist of single statment
        }
    }
}
