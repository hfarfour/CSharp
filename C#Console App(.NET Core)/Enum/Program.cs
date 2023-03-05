using System;



// an enum is used to assign constant names to a group of numeric integer values.

//The enum can be of any numeric data type such as byte, sbyte, short, ushort, int, uint, long, or ulong.
//However, an enum cannot be a string type.

//Enum alway public and no access modifier can be applied. (value can not be changed. weekDays.Sunday = 12))

// Enum can only be declaree in side a class or in namespace

// Enum is a value tpye
// Enum is derived from the object class
// Enum can not be string
// Enum defalut value is int
// two or more memebrs of the enum can have the same value / Sundy = 0, ManDay = 0,


namespace Enum
{
    enum WeekDays
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Destination
    {
        London,
        Frankfurt,
        Berlin
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Monday);
            Console.WriteLine(WeekDays.Tuesday);
            Console.WriteLine(WeekDays.Wednesday);
            Console.WriteLine(WeekDays.Thursday);
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine(WeekDays.Saturday);
            Console.WriteLine(WeekDays.Sunday);
            Console.WriteLine("");
            //Explicit casting is required to convert from an enum type to its underlying integral type.
            Console.WriteLine(WeekDays.Monday);
            int day = (int)WeekDays.Monday;
            Console.WriteLine(day);
            Console.WriteLine("");
            Console.WriteLine(WeekDays.Sunday);
            int days = (int)WeekDays.Sunday;
            Console.WriteLine(days);
            Console.WriteLine("");

            var holiday = WeekDays.Friday;
            Console.WriteLine("{0},{1}",holiday,(int) holiday);

            // check flight
            CheckFlight(Destination.London);
            Console.WriteLine("");

            //switch
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
            //}

            int result = 1;
            try
            {
                // Attempt to convert the user's input into a number
                result = Int32.Parse(meals);
            }
            catch (FormatException)
            {
                // If the user's input is invalid, display a warning and exit the application
                Console.WriteLine($"'{meals}' is an invalid format. Please enter a number.");
                System.Environment.Exit(1);
            }
            switch (result)
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
            }
        }

        public static void CheckFlight(Destination selection)
        {
            switch (selection)
                {
                    case Destination.London:
                        Console.WriteLine($"this flight to london 201 ");
                        break;
                    case Destination.Berlin:
                        Console.WriteLine($"this flight to Brlin 210 ");
                        break;
                    case Destination.Frankfurt:
                        Console.WriteLine($"this flight to Frankfurt 514 ");
                        break;  
                }
        }
    }

}
