using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========for Loop===========");
            //An Initializer, condition, and iterator sections are optional.
            //You can initialize a variable before for loop, and condition and iterator
            //can be defined inside a code block, as shown below.
            int i = 0;
            for (; ; )
            {
                if (i < 10)
                {
                    Console.WriteLine("Value of i: {0}", i);
                    i++;
                }
                else
                    break;
            }
            Console.WriteLine("=======");
            for (int I = 0, j = 0; I + j < 5; I++, j++)
            {
                Console.WriteLine("Value of I: {0}, J: {1} ", I, j);
            }


            Console.WriteLine("=======");
            int e = 0, r = 5;
            for (Console.WriteLine($"Initializer: i={e}, j={r}");
                 e++ < r--;
                 Console.WriteLine($"Iterator: i={e}, j={r}"))
            {
            }




            Console.WriteLine("=========while Loop===========");
            //provides the while loop to repeatedly execute a block of code as long as the specified condition returns true.
            int p = 0; // initialization
            while (p < 10) // condition
            {
                Console.WriteLine("p = {0}", p);
                p++; // increment
            }
            //Use the break or return keyword to exit from a while loop on some condition, as shown below.
            int f = 0;
            while (true)
            {
                Console.WriteLine("f = {0}", f);
                f++;
                if (f > 10)
                    break;
            }

            Console.WriteLine("=======");
            int l = 0, k = 1;
            while (l < 2)
            {
                Console.WriteLine("l = {0}", l);
                l++;
                while (k < 2)
                {
                    Console.WriteLine("k = {0}", k);
                    k++;
                }
            }




            Console.WriteLine("=========do while loop===========");
            //The do while loop is the same as while loop except that it executes the code block at least once.
            int d = 0;
            do
            {
                Console.WriteLine("d = {0}", d);
                d++;
                //if (d > 5)
                //    break;
            } while (d < 10);


            //Nested do -while
            int Y = 0;
            do
            {
                Console.WriteLine("Value of Y: {0}", Y);
                int a = Y;
                Y++;
                do
                {
                    Console.WriteLine("Value of a: {0}", a);
                    a++;
                } while (a < 2);
            } while (Y < 2);
        }
    }
}
