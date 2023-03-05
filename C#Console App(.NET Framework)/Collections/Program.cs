using System;
using System.Collections; // non generic
using System.Collections.Generic; // generic like list
using System.Linq;
//series of values or objects are called collections.
//There are two types of collections available in C#: non-generic collections and generic collections.
// it is recommended to use the generic collections because they perform faster than non-generic collections
//and also minimize exceptions by giving compile-time errors.
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============ArrayList================");
            //1-is a non-generic collection of objects whose size increases dynamically.
            //It is the same as Array except that its size increases dynamically.
            //2- use it when we do not konw thw data type and the size.
            //3-An ArrayList can contain multiple null and duplicate values.

            var arrayList = new ArrayList(); // recommended
            arrayList.Add(1);
            arrayList.Add("hossam");
            arrayList.Add(" ");
            arrayList.Add(true);
            arrayList.Add(4.3);
            arrayList.Add(null);
            Console.WriteLine("ArratList 1 elements");
            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine(arrayList[i]);

            //or
            ArrayList array = new ArrayList()
            {
                1,"hossam"," ",true,4.3,null
            };
            Console.WriteLine("ArratList 2 elements");
            for (int i = 0; i < array.Count; i++)
                Console.WriteLine(array[i]);


            //Use the AddRange(ICollection c) method to add an entire Array,
            //HashTable, SortedList, ArrayList, BitArray, Queue, and Stack in the ArrayList.
            var arlist1 = new ArrayList();
            var arlist2 = new ArrayList()
                            {
                                1, "Bill", " ", true, 4.5, null
                            };

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist1.AddRange(arlist2); //adding arraylist in arraylist 
            arlist1.AddRange(arr); //adding array in arraylist 
            arlist1.AddRange(myQ); //adding Queue in arraylist 
            Console.WriteLine("ArrayList Elements contains:");
            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);
            Console.WriteLine("");

            //=======Accessing an ArrayList=========
            var arlist = new ArrayList()
                {
                    1,
                    "test",
                    300,
                    4.5f
                };

            //Access individual item using indexer
            int firstElement = (int)arlist[0]; //returns 1
            string secondElement = (string)arlist[1]; //returns "Bill"
            int thirdElement = (int)arlist[2];

            //using var keyword without explicit casting
            var first = arlist[0]; //returns 1
            var second = arlist[1]; //returns "Bill"
            var third = arlist[2];
            var forth = arlist[3];
            // var fifthElement = arlist[5]; //Error: Index out of range

            Console.WriteLine("");
            //update elements
            arlist[0] = "Steve";
            arlist[1] = 100;
            arlist[2] = 500;
            for (var i = 0; i < arlist.Count; i++)
                Console.WriteLine(arlist[i]);
            Console.WriteLine(".......");
            //or
            //foreach (var item in arlist)
            //{
            //    Console.writeLine(item + ", ");
            //}


            // insert in arraylist
            arlist.Insert(0, "first Item");
            arlist.Insert(1, "Second Item");
            arlist.Insert(2, 1990);
            arlist.Insert(3, true);
            foreach (var val in arlist)
                Console.WriteLine(val);
            Console.WriteLine(".......");


            //insert range
            ArrayList arlist5 = new ArrayList()
                {
                    100, 200, 600
                };
            ArrayList arlist6 = new ArrayList()
                {
                    300, 400, 500
                };
            arlist5.InsertRange(2, arlist6);
            foreach (var item in arlist5)
                Console.WriteLine(item + ", ");
            Console.WriteLine("..... ");



            //remove elemnnts
            ArrayList arList8 = new ArrayList()
                {
                    1,
                    null,
                    "Bill",
                    300,
                    " ",
                    4.5f,
                    700
                };
            foreach (var item in arList8)
                Console.WriteLine(item);
            Console.WriteLine("..... ");
            arList8.Remove(null); //Removes first occurance of null
            arList8.RemoveAt(4); //Removes element at index 4
            arList8.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)

            foreach (var item in arList8)
                Console.WriteLine(item);
            Console.WriteLine("..... ");

            Console.WriteLine(arList8.Contains("Bill")); // fasle // removed
            Console.WriteLine("==============================================================================");







            Console.WriteLine("===============List<T>================");
            //The List<T> is a collection of strongly typed objects that can be accessed by index
            //and having methods for sorting, searching, and modifying list.
            //It is the generic version of the ArrayList that comes under System.
            //Collections.Generic namespace.

            //List<T> can contain elements of the specified type.
            //It provides compile-time type checking and doesn't perform boxing-unboxing because it is generic.

            //List<T> performs faster and less error-prone than the ArrayList.

            //Generic List<T> contains elements of specified type.It grows automatically as you add elements in it.
            // adding elements using add() method
            var primeNumbers = new List<int>(); // generic so can be int or string
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            foreach (var i in primeNumbers)
                Console.WriteLine(i);
            Console.WriteLine("");

            //or
            List<string> arList10 = new List<string>();
            {
                arList10.Add("Issa");
                arList10.Add("Yildiz");
                arList10.Add("Ali");
                arList10.Add("Tess");
                arList10.Add(null); // null is allowed
            };
            foreach (var i in arList10)
                Console.WriteLine(i);
            Console.WriteLine("");


            var bigCities = new List<string>()
            {
                "New York",
                "London",
                "Mumbai",
                "Chicago"
            };
            foreach (var i in bigCities)
                Console.WriteLine(i);
            Console.WriteLine("");


            // Anonymous Type
            var students = new List<Student>() //or list<Student> students =  new List<Student>()
            {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };
            // LINQ Query
            var Details = from s in students
                          select new
                          {
                              Id = s.Id,
                              Name = s.Name,
                          };

            foreach (var s in students)
            {
                Console.WriteLine($"stduent: {s.Id} { s.Name}");
            }
            Console.WriteLine("");

            var studNames = from s in students
                            where s.Name == "Bill"
                            select s;
            foreach (var student in studNames)
                Console.WriteLine($"stdent name Id and name {student.Id} {","} {student.Name}");

            //Add Arrays in List
            string[] cities = new string[3] { "Mumbai", "London", "New York" };
            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(cities);
            foreach (var i in popularCities)
                Console.WriteLine(i);
            Console.WriteLine("");
            var favouriteCities = new List<string>();
            // adding a List 
            favouriteCities.AddRange(popularCities);
            foreach (var i in favouriteCities)
                Console.WriteLine(i);
            Console.WriteLine("");


            // Insert Elements in List
            var numbers = new List<int>() { 10, 20, 30, 40 };
            numbers.Insert(1, 11);// inserts 11 at 1st index: after 10.
            foreach (var num in numbers)
                Console.WriteLine(num);
            Console.WriteLine("");


            //remove
            var number = new List<int>() { 10, 20, 30, 40, 10 };
            number.Remove(10); // removes 10 elements from a list
            number.RemoveAt(2); //removes the 3rd element (index starts from 0)
            foreach (var num in number)
                Console.WriteLine(num);


            // check for value return true or false
            var nums = new List<int>() { 10, 20, 30, 40 };
            Console.WriteLine(nums.Contains(10));
            Console.WriteLine(nums.Contains(11));
            Console.WriteLine(nums.Contains(20));
            Console.WriteLine("");
            Console.WriteLine("==============================================================================");
          







            Console.WriteLine("=============== SortedList<TKey, TValue>================");
            //C# supports generic and non-generic SortedList. It is recommended to use generic SortedList<TKey, TValue>
            //because it performs faster and less error-prone than the non-generic SortedList.

            //1-SortedList<TKey, TValue> is an array of key-value 
            //2-A key must be unique and cannot be null but key cannot be null
            //3-A value can be null or duplicate.
            //4-A value can be accessed by passing associated key in the indexer mySortedList[key]
            //5-Sorts elements as soon as they are added


            //SortedList of int keys, string values 
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");

            foreach (var kvp in numberNames)
                Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);
            Console.WriteLine("");
            //Creating a SortedList of string keys, string values 
            SortedList<string, string> Somecities = new SortedList<string, string>()
                 {
                     {"London", "UK"},
                     {"New York", "USA"},
                     { "Mumbai", "India"},
                     {"Johannesburg", "South Africa"}
                  };
            foreach (var kvp in Somecities)
             Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);



            Console.WriteLine(" //add");
            //add
            Somecities.Add ("Aleppo" , "Syria");
            foreach (KeyValuePair<string, string> kvp in Somecities)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);



            Console.WriteLine(" access");
            Console.WriteLine(Somecities["London"]); 
            Console.WriteLine(Somecities["New York"]);
            Console.WriteLine(Somecities["Mumbai"]);



            Console.WriteLine(" updates value");
            Console.WriteLine(Somecities["London"] = "Great Britin");
            foreach (KeyValuePair<string, string> kvp in Somecities)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);


            Console.WriteLine("check value");
            //Console.WriteLine(Somecities["Ahsm"]); //run-time KeyNotFoundException so use if statment
            if (!Somecities.ContainsKey("Baghdad")) //check if key exists
            {
                Somecities["Baghdad"] = "Iraq";
            }
            foreach (KeyValuePair<string, string> kvp in Somecities)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
        
            string result;
            if (Somecities.TryGetValue("Baghdad", out result)) // try to get value of "Baghdad" key
                Console.WriteLine("Key: {0}, Value: {1}", "Baghdad", result);



            Console.WriteLine("remove key");
            Somecities.Remove("Aleppo");
            for (int i = 0; i < Somecities.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", Somecities.Keys[i], Somecities.Values[i]);
            }
            Console.WriteLine("==============================================================================");










            Console.WriteLine("=================== Dictionary<TKey, TValue>==================");
            //The Dictionary<TKey, TValue> is a generic collection that stores key-value pairs in no particular order.
            //Elements are stored as KeyValuePair<TKey, TValue> objects.
            Dictionary<int, string> numbersNames = new Dictionary<int, string>();
            numbersNames.Add(1, "One"); //adding a key/value using the Add() method
            numbersNames.Add(2, "Two");
            numbersNames.Add(3, "Three"); 

            foreach (KeyValuePair<int, string> kvp in numbersNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //creating a dictionary using collection-initializer syntax
            var Somecity = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
            foreach (var kvp in Somecity)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);


            Console.WriteLine(" //add");
            //add
            Somecity.Add("Aleppo", "Syria");
            foreach (KeyValuePair<string, string> kvp in Somecity)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);



            Console.WriteLine(" access");
            Console.WriteLine(Somecity["UK"]);
            Console.WriteLine(Somecity["USA"]);
            Console.WriteLine(Somecity["India"]);



            Console.WriteLine(" updates value");
            Somecity["USA"] = "$";
            foreach (KeyValuePair<string, string> kvp in Somecity)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            //or
            if (Somecity.ContainsKey("France"))
            {
                Somecity["France"] = "Paris";
            }

            Console.WriteLine("check value");
            //Console.WriteLine(Somecities["Ahsm"]); //run-time KeyNotFoundException so use if statment
            if (!Somecity.ContainsKey("Baghdad")) //check if key exists
            {
                Somecity["Baghdad"] = "Iraq";
            }
            foreach (KeyValuePair<string, string> kvp in Somecity)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            string results;
            if (Somecities.TryGetValue("Baghdad", out results)) // try to get value of "Baghdad" key
                Console.WriteLine("Key: {0}, Value: {1}", "Baghdad", results);



            Console.WriteLine("remove key");
            Somecity.Remove("India");
            for (int i = 0; i < Somecity.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", Somecity.ElementAt(i).Key, Somecity.ElementAt(i).Value);
            }
          
            Console.WriteLine("==============================================================================");






            Console.WriteLine("=========================Hashtable=======================");
            //The Hashtable is a non-generic collection that stores key-value pairs, similar to generic Dictionary<TKey, TValue> collection.
            //It optimizes lookups by computing the hash code of each key and stores it in a different bucket
            //internally and then matches the hash code of the specified key at the time of accessing values.

            //Elements are stored as DictionaryEntry objects.

            Hashtable SomeNumberName = new Hashtable();
            SomeNumberName.Add(1, "One");
            SomeNumberName.Add(2, "Two");
            SomeNumberName.Add(3, "Three");
            foreach (DictionaryEntry de in SomeNumberName)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            //creating a Hashtable using collection-initializer syntax
            var Country = new Hashtable()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
            foreach (DictionaryEntry de in Country)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            Console.WriteLine("===add===");
            //add
            Country.Add("Aleppo", "Syria");
            foreach (DictionaryEntry de in Country)
                Console.WriteLine("key: {0}, value: {1}", de.Key, de.Value);



            Console.WriteLine(" access");
            string citiesOfUK = (string)Country["UK"]; //cast to string
            string citiesOfUSA = (string)Country["USA"]; //cast to string
            Console.WriteLine(citiesOfUK);
            Console.WriteLine(citiesOfUSA);
            //or
            //Console.WriteLine(Country["UK"]);
            //Console.WriteLine(Country["USA"]);
            //Console.WriteLine(Country["India"]);


            Console.WriteLine(" updates value");
            Country["UK"] = "£";
            foreach (DictionaryEntry de in Country)
                Console.WriteLine("key: {0}, value: {1}", de.Key, de.Value);
            //or
            if (Country.ContainsKey("France"))
            {
                Country["France"] = "Paris";
            }

            Console.WriteLine("check value");
            //Console.WriteLine(Country["Ahsm"]); //run-time KeyNotFoundException so use if statment
            if (!Country.ContainsKey("Baghdad")) //check if key exists
            {
                Country["Baghdad"] = "Iraq";
            }
            foreach (DictionaryEntry de in Country)
                Console.WriteLine("key: {0}, value: {1}", de.Key, de.Value);

            Console.WriteLine("remove key");
            Country.Remove("India");
            foreach (DictionaryEntry de in Country)
                Console.WriteLine("key: {0}, value: {1}", de.Key, de.Value);
            Console.WriteLine("==============================================================================");






            Console.WriteLine("=========================Stack<T>======================");
            //Stack is a special type of collection that stores elements in LIFO style (Last In First Out).
            //C# includes the generic Stack<T> and non-generic Stack collection classes.
            //It is recommended to use the generic Stack<T> collection.
            //Elements can be added using the Push() method. Cannot use collection-initializer syntax.
            //Elements can be retrieved using the Pop() and the Peek() methods.
            //It does not support an indexer.
            //Push(T)	Inserts an item at the top of the stack.
            //Peek()  Returns the top item from the stack.
            // Pop()   Removes and returns items from the top of the stack.
            //Contains(T) Checks whether an item exists in the stack or not.
            //Clear()

            //includes the generic Stack<T> and non-generic Stack collection classes.
            //It is recommended to use the generic Stack<T> collection.
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            foreach (var item in myStack)
                Console.Write(item + ",");
            Console.WriteLine(" ");

            //Create and Add Elements in Stack
            int[] arry = { 1, 2, 3, 4 };
            Stack<int> myStacks = new Stack<int>(arry);
            foreach (var item in myStacks)
                Console.Write(item + ",");
            Console.WriteLine(" ");

            Console.WriteLine("===Peek()== ");
            Console.WriteLine( myStack.Peek()); // print 4

            Console.WriteLine("===pop()== ");
            while (myStack.Count > 0)
                Console.WriteLine(myStack.Pop() + ",");
            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);

            Console.WriteLine("==============================================================================");






            Console.WriteLine("=======================Queue<T>======================");
            //Queue is a special type of collection that stores the elements in FIFO style (First In First Out),

            //includes generic Queue<T> and non-generic Queue collection.
            //It is recommended to use the generic Queue<T> collection.

            //Elements can be added using the Enqueue() method. Cannot use collection-initializer syntax.
            //Elements can be retrieved using the Dequeue() and the Peek() methods.It does not support an indexer.
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            foreach (var item in myStack)
                Console.Write(item + ",");
            Console.WriteLine(" ");

            //Create and Add Elements in queue
            int[] arrys = { 1, 2, 3, 4 };
            Queue<int> myQueues = new Queue<int>(arrys);
            foreach (var item in myQueues)
                Console.Write(item + ",");
            Console.WriteLine(" ");

            Console.WriteLine("===Peek()=== ");
            Console.WriteLine(myQueue.Peek());

            Console.WriteLine("===Dequeue()=== ");
            while (myQueue.Count > 0)
                Console.WriteLine(myQueue.Dequeue() + ",");
            Console.WriteLine("Number of elements in queue: {0}", myQueue.Count);
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}



