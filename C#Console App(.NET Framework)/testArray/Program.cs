using System;
using System.Linq;

//A variable is used to store a literal value, whereas an array is used to store multiple literal values.
//In C#, an array can be of three types: single-dimensional, multidimensional, and jagged array.

//sintax  Array.ForEach<int>(Somenum, n => Console.WriteLine(n));

namespace testArray
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("======singledimensional Arrays=======");
            // array declaration
            int[] evenNums = new int[] { 2, 4, 6, 8, 10 };
            foreach (int i in evenNums)
            {
                Console.WriteLine(i);
            }
            string[] cities = new string[] { "Mumbai", "London", "New York" };
            Console.WriteLine(cities[0]);
            Console.WriteLine("");


            int[] evenNum = { 2, 4, 6, 8, 10, 12, 14, 16 };
            foreach (int i in evenNum)
            {
                Console.WriteLine(i);
            }
            string[] citie = { "Mumbai", "London", "New York" };
            Console.WriteLine("");

            //cannot use var with array initializer and in function parameter
            // var evenNums = { 2, 4, 6, 8, 10 };


            //Late Initialization
            int[] evenNumber;
            // evenNumber = new int[5];
            // or
            evenNumber = new int[] { 2, 4, 6, 8, 10 };
            evenNumber[0] = 14;
            evenNumber[1] = 16;
            evenNumber[2] = 18;
            evenNumber[3] = 20;
            foreach (int i in evenNumber)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            Console.WriteLine($"max is: { evenNumber.Max()}");
            Console.WriteLine($"min is: {evenNumber.Min()}");
            Console.WriteLine($"sum is: {evenNumber.Sum()}");
            Console.WriteLine($"average is: {evenNumber.Average()}");
            Console.WriteLine("");

            int[] Somenum = { 10, 15, 16, 8, 6 };
            Console.WriteLine("Original Array");
            foreach (var element in Somenum)
                Console.WriteLine(element);

            Array.Sort(Somenum);
            Console.WriteLine("Sorted Array");
            foreach (var element in Somenum)
                Console.WriteLine(element);


            Array.Reverse(Somenum);
            Console.WriteLine("Reversed Array");
            Array.ForEach<int>(Somenum, n => Console.WriteLine(n));
            Console.WriteLine("");
            Console.WriteLine(Array.BinarySearch(Somenum, 6));
            Console.WriteLine("");


            //Passing Array as Argument
            static void UpdateArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = arr[i] + 10;
            }
            int[] nums = { 1, 2, 3, 4, 5 };
            UpdateArray(nums);
            foreach (var item in nums)
                Console.WriteLine(item);

            Console.WriteLine("");


            Console.WriteLine("======Multidimensional Arrays=======");
            int[,] arr2d = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };

            Console.WriteLine(arr2d[0, 0]);
            Console.WriteLine(arr2d[0, 1]);
            Console.WriteLine(arr2d[1, 0]);
            Console.WriteLine(arr2d[1, 1]);
            Console.WriteLine(arr2d[2, 0]);
            Console.WriteLine(arr2d[2, 1]);

            Console.WriteLine("");
            //the first rank indicates the number of rows of inner two - dimensional arrays.
            int[,,] arr3d2 = new int[2, 2, 2]{
                { {1, 2}, {3, 4} },
                { {5, 6}, {7, 8} }
            };
            Console.WriteLine(arr3d2[1, 1, 1]);
            Console.WriteLine("");


            int[,,,] arr4d1 = new int[1, 1, 2, 2]{
                {
                    { { 1, 2}, { 3, 4} }
                }
            };
            Console.WriteLine(arr4d1[0, 0, 1, 0]);
            Console.WriteLine("");


            int[,,,] arr4d2 = new int[1, 2, 2, 2]{
           {
             { {1, 2}, {3, 4} },
             { {5, 6}, {7, 8} }
           }
        };
            Console.WriteLine(arr4d2[0, 1, 1, 0]);
            Console.WriteLine("");




            Console.WriteLine("=======Jagged Arrays: An Array of Array=======");
            //A jagged array is an array of array. Jagged arrays store arrays instead of literal values.

            //A jagged array is initialized with two square brackets [][].
            //The first bracket specifies the size of an array,
            //and the second bracket specifies the dimensions of the array which is going to be stored.

            int[][] jArray1 = new int[2][]; // can include two single-dimensional arrays 
            int[][,] jArray2 = new int[3][,]; // can include three two-dimensional arrays

            int[][] jArray = new int[2][] {
                new int[3]{1, 2, 3},  // 0
                new int[4]{4, 5, 6, 7} // 1
        };

            Console.WriteLine(jArray[0][0]);
            Console.WriteLine(jArray[0][1]);
            Console.WriteLine(jArray[0][2]);
            Console.WriteLine(jArray[1][0]);
            Console.WriteLine(jArray[1][1]);
            Console.WriteLine(jArray[1][2]);
            Console.WriteLine(jArray[1][3]);
            Console.WriteLine("");
            //You can access a jagged array using two for loops, as shown below.
            for (int i = 0; i < jArray.Length; i++)
            {
                for (int j = 0; j < (jArray[i]).Length; j++)
                    Console.WriteLine(jArray[i][j]);
            }
            Console.WriteLine("");



            int[][,] jaggedArray = new int[2][,] {
             new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } },
             new int[2, 2] { { 7, 8 }, { 9, 10 } }
          };
            Console.WriteLine(jaggedArray[0][0, 0]);
            Console.WriteLine(jaggedArray[0][0, 1]);
            Console.WriteLine(jaggedArray[0][1, 0]);
            Console.WriteLine(jaggedArray[0][1, 1]);

            Console.WriteLine(jaggedArray[1][0, 0]);
            Console.WriteLine(jaggedArray[1][0, 1]);
            Console.WriteLine(jaggedArray[1][1, 0]);
            Console.WriteLine(jaggedArray[1][1, 1]);
            Console.WriteLine("");



            //If you add one more bracket then it will be array of array of arry.
            int[][][] intJaggedArray = new int[2][][]
        {
            new int[2][]
            {
                new int[3] { 1, 2, 3},
                new int[2] { 4, 5}
            },
            new int[1][]
            {
                new int[3] { 7, 8, 9}
            }
        };
            Console.WriteLine(intJaggedArray[0][0][0]); // 1
            Console.WriteLine(intJaggedArray[0][1][1]); // 5
            Console.WriteLine(intJaggedArray[1][0][2]); // 9
        }
    }
}
