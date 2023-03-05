using System;

//try block: Any suspected code that may raise exceptions
//catch block: The catch block is an exception handler block where you can perform some action
//finally block: The finally block will always be executed whether an exception raised or not

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Enter a number: "); // enter non-numeric value to see the exception
            //var num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Squre of {0} is {1}", num, num * num);

            // To handle the possible exceptions in the above example,
            try
            {
                Console.WriteLine("Enter a number: ");
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine("Squre of {0} is {1}", num, num * num);
            }
            catch
            {
                Console.WriteLine("Error occurred.");
            }
            finally // always will excuited 
            {
                Console.WriteLine("Re-try and enter int number.");
            }
            Console.WriteLine("====");



            Console.WriteLine("====Exception type parameter that catches all types of exceptions.===");
            try
            {
                Console.WriteLine("Enter a number: ");
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine("Squre of {0} is {1}", num, num * num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error info:" + ex.Message);
            }
            Console.WriteLine("====");



            Console.WriteLine("=========Exception Filters========");
            //You can use multiple catch blocks with the different exception type parameters.
            //This is called exception filters. Exception filters are useful when you want
            //to handle different types of exceptions in different ways.
        }

    }
}
