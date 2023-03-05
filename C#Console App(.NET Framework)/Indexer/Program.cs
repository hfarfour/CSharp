using System;


//An indexer is a special type of property that allows a class or a structure to be accessed like
//an array for its internal collection.
//C# allows us to define custom indexers, generic indexers, and also overload indexers.

//An indexer can be defined the same way as property with this keyword and square brackets [].

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======custom indexers==========");
            StringDataStore strStore = new StringDataStore();
            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";
            strStore[4] = "Five";
            for (int i = 0; i <10; i++) // can not use strArr.Length to use it need method (see below).
                Console.WriteLine(strStore[i]);
            Console.WriteLine("");





            Console.WriteLine("=======Generic Indexer==========");
            DataStore<int> grades = new DataStore<int>();
            grades[0] = 100;
            grades[1] = 25;
            grades[2] = 34;
            grades[3] = 42;
            grades[4] = 12;
            grades[5] = 18;
            grades[6] = 2;
            grades[7] = 95;
            grades[8] = 75;
            grades[9] = 53;
            for (int i = 0; i < grades.Length; i++)
                Console.WriteLine(grades[i]);
            Console.WriteLine("");

            DataStore<string> names = new DataStore<string>(5);
            names[0] = "Steve";
            names[1] = "Bill";
            names[2] = "James";
            names[3] = "Ram";
            names[4] = "Andy";
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);
            Console.WriteLine("");
           




            Console.WriteLine("=======Overload Indexer==========");
            //You can be overloaded with the different data types for index.
            //The following example overloads an indexer with int type index as well as string type index.
            StringOverload strOverload = new StringOverload();
            strOverload[0] = "one";
            strOverload[1] = "two";
            strOverload[2] = "three";
            strOverload[3] = "four";
            strOverload[4] = "five";
            for (int i = 0; i < strOverload.Length; i++)
                Console.WriteLine(strOverload[i]);
            Console.WriteLine("");


           //question
            //Console.WriteLine(strOverload["Ali"]);
            //Console.WriteLine(strOverload["Ali"]);
            //Console.WriteLine(strOverload["Daniz"]);
            //Console.WriteLine(strOverload["Dalal"]);
            //Console.WriteLine(strOverload["Jon"]);
            Console.WriteLine("");
        }
    }

    //for custom indexers
    public class StringDataStore
    {
        private string[] strArr = new string[10]; // internal data storage
        public string this[int index]
        {
            //get
            //{
            //    if (index < 0 || index >= strArr.Length)
            //        throw new IndexOutOfRangeException("Cannot store more than 10 objects");

            //    return strArr[index];
            //}

            //set
            //{
            //    if (index < 0 || index >= strArr.Length)
            //        throw new IndexOutOfRangeException("Cannot store more than 10 objects");

            //    strArr[index] = value;
            //}
            //or
           //You can use expression-bodied syntax for get and set
            get => strArr[index];
            set => strArr[index] = value;
        }
    }


    //for  Genaric indexer
    class DataStore<T>
    {
        //A generic class can include generic fields. However, it cannot be initialized.
        private T[] store ;    //or private T[] store = new T[10];

        // constructor without paramenter
        public DataStore()
        {
            store = new T[10]; // must have array size
        }
        // constructor with one paramenter
        public DataStore(int length)
        {
            store = new T[length];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= store.Length)
                    throw new IndexOutOfRangeException("Index out of range");
                return store[index];
            }

            set
            {
                if (index < 0 || index >= store.Length)
                    throw new IndexOutOfRangeException("Index out of range");
                store[index] = value;
            }
            //or
            //get => store[index];
            //set => store[index] = value;
        }

        // for the .length in the for loop
        public int Length
        {
            get
            {
                return store.Length;
            }
        }
    }


    //for overload Indexer
    public class StringOverload
    {
        private string[] strArrs = new string[10]; // internal data storage
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= strArrs.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");
                return strArrs[index];
            }

            set
            {
                if (index < 0 || index >= strArrs.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");
                strArrs[index] = value;
            }
        }
        public string this[string name]
        {                                               //============== //question==================
            
            // get => name.ToString(strArrs [name]);
            //set => strArrs[name] = value;
        }
        public int Length
        {
            get
            {
                return strArrs.Length;
            }
        }

    }

}
