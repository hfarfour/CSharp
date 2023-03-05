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

            Console.Write("Please enter a number to divide 100: ");
            try
            {
                int num = int.Parse(Console.ReadLine());
                int result = 100 / num;
                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Not a valid format. Please try again.");
            }
            catch (NullReferenceException nullEx)
            {
                Console.WriteLine(nullEx.Message);
            }
            catch (InvalidCastException inEx)
            {
                Console.WriteLine(inEx.Message);
            }

            //this Exception must be the last catch plock // otherwise will get run time error
            // can not have catch and catch(Exception ex) togather
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred!" + ex.Message);
            }




            Console.WriteLine("========= Nested try-catch========");
            //Inner catch"
            var divider = 0;
            try
            {
                try
                {
                    var result = 100 / divider;
                }
                catch
                {
                    Console.WriteLine("Inner catch");
                }
            }
            catch
            {
                Console.WriteLine("Outer catch");
            }

            //outer catch
            var dividers = 0;
            try
            {
                try
                {
                    var result = 100 / dividers;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Inner catch");
                }
            }
            catch
            {
                Console.WriteLine("Outer catch");
            }

        }

    }
}
