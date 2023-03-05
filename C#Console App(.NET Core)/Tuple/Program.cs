using System;
using System.Collections;
using System.Collections.Generic;

//A tuple is a data structure that contains a sequence of elements of different data types.
//It can be used where you want to have a data structure to hold an object with properties,
//but you don't want to create a separate type for it.

//A tuple can only include a maximum of eight elements. It gives a compiler error when you try to include more than eight elements

//1-When you want to return multiple values from a method without using ref or out parameters.
//2-When you want to pass multiple values to a method through a single parameter.
//3-When you want to hold a database record or some values temporarily without creating a separate class

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=====================Tuple===================");
            Tuple<int , string, string> person = new Tuple<int, string, string>(1, "Steve", "Jobs");
            Console.WriteLine(person.Item1); // returns 1
            Console.WriteLine(person.Item2); // returns "Steve"
            Console.WriteLine(person.Item3); // returns "Jobs"

            //ncludes a static helper class Tuple, which returns an instance of the
            //Tuple<T> without specifying each element's type, as shown below.
            var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
            Console.WriteLine(numbers.Item1); // returns "One"
            Console.WriteLine(numbers.Item2); // returns 2
            Console.WriteLine(numbers.Item3); // returns 3
            Console.WriteLine(numbers.Item4); // returns "Four"
            Console.WriteLine(numbers.Item5); // returns 5
            Console.WriteLine(numbers.Item6); // returns "Six"
            Console.WriteLine(numbers.Item7); // returns 7
            Console.WriteLine(numbers.Rest); // returns (8)
            Console.WriteLine(numbers.Rest.Item1); // returns 8
           //Generally, the 8th position is for the nested tuple, which you can access using the Rest property.

            //If you want to include more than eight elements in a tuple, you can do that by nesting
            //another tuple object as the eighth element. The last nested tuple can be accessed using the Rest property.
            //To access the nested tuple's element, use the Rest.Item1.Item<elelementNumber> property.
            Console.WriteLine("========");
            var number = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(number.Item1); // returns 1
            Console.WriteLine(number.Item7); // returns 7
            Console.WriteLine(number.Rest.Item1); //returns (8, 9, 10, 11, 12, 13)
            Console.WriteLine(number.Rest.Item1.Item1); //returns 8
            Console.WriteLine(number.Rest.Item1.Item2); //returns 9
            Console.WriteLine("=======");


            //You can include the nested tuple object anywhere in the sequence.
            //However, it is recommended to place the nested tuple at the end of the sequence so that it
            //can be accessed using the Rest property.

            var Somenumbers = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);
            Console.WriteLine(Somenumbers.Item1); // returns 1
            Console.WriteLine(Somenumbers.Item2); // returns 2
            Console.WriteLine(Somenumbers.Item3); // returns (3, 4, 5, 6, 7,  8)
            Console.WriteLine(Somenumbers.Item3.Item1); // returns 3
            Console.WriteLine(Somenumbers.Item4); // returns 9
            Console.WriteLine(Somenumbers.Rest.Item1); //returns 13
            Console.WriteLine("=======");


            Console.WriteLine("=======Tuple as a Method Parameter======");
            var Pers = Tuple.Create(1990, "hossam", "farfour");
            DisplayTuple(Pers);


            Console.WriteLine("=======Tuple as a Return Type======");
            var RetunPerson = GetPerson();
            Console.WriteLine(GetPerson());
            Console.WriteLine("================================================================");







            Console.WriteLine("=====================ValueTuple===================");
            // there is no need for new ValueTuple<>(); ValueTuple<int,string,string>person1=(1,"Issa","Farfour");
            //there is no need for Valuetuple.Creat(); var person12 = (1, "Test", "Test");
            //It can be created and initialized using parentheses () and specifying the values in it.
            //a ValueTuple can include more than eight values.
            // tuple need at least two vlaues  // var person12 = (1, "Test");

            ValueTuple<int, string, string> person1 = (1,"Issa", "Farfour");
            Console.WriteLine(person1.Item1); // returns 1
            Console.WriteLine(person1.Item2); // returns "Bill"
            Console.WriteLine(person1.Item3); // returns "Gates"

            //or
            (int, string, string) person2 = (2, "James", "Bond");
            Console.WriteLine(person2.Item1); // returns 1
            Console.WriteLine(person2.Item2); // returns "James"
            Console.WriteLine(person2.Item3); // returns "Bond"
            Console.WriteLine("======");
          

            // We can assign names to the ValueTuple properties instead of having the default property names like Item1, Item2 and so on.
            (int id, string FirstName, string LastName) man = (1, "Ali", "Been tested");
            Console.WriteLine(man.id); // returns 1
            Console.WriteLine(man.FirstName); // returns "Bill"
            Console.WriteLine(man.LastName); // returns "Gates"
            Console.WriteLine("=======");


            //We can also assign member names on the right side with values, but will be ignored it takes names on the left side
            (int id, string FirstName, string LastNmae) person13 = (Id:2, FirstName: "Wesam", LastNme: "Farfour");
            Console.WriteLine(person13.id);
            Console.WriteLine(person13.FirstName);
            Console.WriteLine(person13.LastNmae); 
            Console.WriteLine("======");


            var person12 = (1, "Test", "Test");
            //equivalent Tuple
            //var person2 = ValueTuple.Create(1, "test", "test");
            var ValueType = (1, 2, ValueTuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);
            Console.WriteLine(ValueType.Item1); // returns 1
            Console.WriteLine(ValueType.Item2); // returns 2
            Console.WriteLine(ValueType.Item3); // returns (3, 4, 5, 6, 7,  8)
            Console.WriteLine(ValueType.Item3.Item1); // returns 3
            Console.WriteLine(ValueType.Item4); // returns 9
            Console.WriteLine(ValueType.Rest.Item1); //returns 13
            Console.WriteLine("=======");



            Console.WriteLine("=======ValueTuple as a Method Parameter======");
            var Person10 = (1994, "Yildiz", "farfour");
            DisplayValueTuple(Person10);


            Console.WriteLine("=======ValueTuple as a Return Type======");
            var RetunPersonS = GetPersonS();
            Console.WriteLine(GetPersonS());



            Console.WriteLine("==========Deconstruct ValueTuple========");
            
            (int Id, string FirstName, string LastName) = Deconstruct();
            Console.WriteLine("{0},{1}, {2}", Id, FirstName, LastName);

            (var PersonId, var FName, var LName) = Deconstruct(); // using var
            Console.WriteLine("{0},{1}, {2}", PersonId, FName, LName);

            (var PId, var Name, _) = Deconstruct(); //discard other members
            Console.WriteLine("{0},{1}", PId, Name);
            Console.WriteLine("================================================================");


        }


        // Tuble as Parameter
        static void DisplayTuple(Tuple<int, string, string> person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
            Console.WriteLine("=======");
        }

        //Tuple as a return type
        static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(1, "Bill", "Farfour");
            
        }

        // VlaueTuble as Parameter
        //static void DisplayValueTuple(ValueTuple<int, string, string> person)
        //{
        //    Console.WriteLine($"Id = { person.Item1}");
        //    Console.WriteLine($"First Name = { person.Item2}");
        //    Console.WriteLine($"Last Name = { person.Item3}");
        //    Console.WriteLine("=======");
        //}
        //or
        static void DisplayValueTuple((int, string, string) person)
        {
            Console.WriteLine("{0}, {1}, {2}", person.Item1, person.Item2, person.Item3);
        }

        //VlaueTuble as a return type
        //static ValueTuple<int, string, string> GetPersonS()
        //{
        //    return (1, "Daniz", "Gates");
        //}

        //or
        static (int, string, string) GetPersonS()
        {
            return (1993, "Daniz", "Gates");
        }

        //Deconstruct ValueTuple
        static (int, string, string) Deconstruct()
        {
            return (Id: 1, FirstName: "Hasna", LastName: "Ali");
        }

    }
}
