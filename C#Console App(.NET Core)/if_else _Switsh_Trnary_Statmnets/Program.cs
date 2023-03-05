using System;

namespace If_else_Statments
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=========If-else-statments=========");
            int i = 10, j = 20;
            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
            if (i < j)
            {
                Console.WriteLine("i is less than j");
            }
            if (i == j)
            {
                Console.WriteLine("i is equal to j");
            }
            Console.WriteLine("==");
            //You can call a function in the if statement that returns a boolean value
            static bool isGreater(int i, int j)
            {
                return i > j;
            }
            if (isGreater(i, j))
            {
                Console.WriteLine("i is less than j");
            }
            if (isGreater(j, i))
            {
                Console.WriteLine("j is greater than i");
            }



            Console.WriteLine("=========Ternary Operator ?:=========");
            //Ternary Operator ?:
            //condition ? statement 1 : statement 2
            int x = 20, y = 10, z = 15;
            var result = x > y ? "x is greater than y" : "x is less than y";
            Console.WriteLine(result);
            Console.WriteLine("==");
            //Nested Ternary Operator
            string results = x > y ? "x is greater than y" :
                             x < y ? "x is less than y" :
                             x == y ? "x is equal to y" : "No result";

            Console.WriteLine(results);
            var resulted = x * 3 > y ? x : y > z ? y : z;
            Console.WriteLine(resulted);





            Console.WriteLine("=========Switch Statement=========");
            //switch
            //The switch statement is an alternative to if else statement.
            //The switch statement tests a match expression/ variable against a set of constants specified as cases.
            // The switch case must include break, return, goto keyword to exit a case.
            //C# 7.0 onward, switch cases can include non-unique values. In this case, the first matching case will be executed.
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Fruit");
            Console.WriteLine("2. Mains");
            Console.WriteLine("3. Desserts");
            Console.WriteLine("");
            // Request user input
            Console.Write(">> ");
            string meals = Console.ReadLine();

            //switch (meals)
            //{
            //    case "1":
            //        Console.WriteLine("Fruits include apples, oranges, and bananas.");
            //        break;

            //    case "2":
            //        Console.WriteLine("Mains include steak, salmon, or risotto.");
            //        break;

            //    case "3":
            //        Console.WriteLine("Desserts include chocolate cake, apple pie, or ice cream.");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown value");
            //        break;
            //}
            // }

            int Result = 1;
            try
            {
                // Attempt to convert the user's input into a number
                Result = Int32.Parse(meals);
            }
            catch (FormatException)
            {
                // If the user's input is invalid, display a warning and exit the application
                Console.WriteLine($"'{meals}' is an invalid format. Please enter a number.");
                System.Environment.Exit(1);
            }
            switch (Result)
            {
                case 1:
                    Console.WriteLine("You selected option 1 (Fruit), which includes apples, oranges, and bananas.");
                    break;

                case 2:
                    Console.WriteLine("You selected option 2 (Mains), which includes steak, salmon, or risotto.");
                    break;

                case 3:
                    Console.WriteLine("You selected option 3 (Desserts), which includes chocolate cake, apple pie or ice cream.");
                    break;

                default:
                    Console.WriteLine("Unknown value");
                    break;
            }

            //The switch statement can also include an expression whose result will be tested against each case at runtime.
            switch (x % 2)
            {
                case 0:
                    Console.WriteLine($"{x} is an even value");
                    break;
                case 1:
                    Console.WriteLine($"{x} is an odd Value");
                    break;
            }


            //return in Switch Case
            var B = 120;
            Console.WriteLine(isOdd(B) ? "Even value" : "Odd value");
            static bool isOdd(int N)
            {
                switch (N % 2)
                {
                    case 0:
                        return true;
                    case 1:
                        return false;
                }
                return false;
            }


            //Nested Switch Statements

            int Z = 5;
            switch (Z)
            {
                case 5:
                    Console.WriteLine(5);
                    switch (Z - 1)
                    {
                        case 4:
                            Console.WriteLine(4);
                            switch (Z - 2)
                            {
                                case 3:
                                    Console.WriteLine(3);
                                    break;
                            }
                            break;
                    }
                    break;
                case 10:
                    Console.WriteLine(10);
                    break;
                case 15:
                    Console.WriteLine(15);
                    break;
                default:
                    Console.WriteLine(100);
                    break;
            }
        }
    }
}
