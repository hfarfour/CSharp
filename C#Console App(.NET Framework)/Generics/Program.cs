using System;
using System.Collections;// non-generic collection types
using System.Collections.Generic; //generic collection types.

//generic means not specific to a particular data type.
//A generic class can be a base class to other generic or non-generic classes or abstract classes.
//A generic class can be derived from other generic or non-generic interfaces, classes, or abstract classes.



namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Generic==========");
            DataStore<string> store = new DataStore<string>();
            store.Data = "Hello World!";
            Console.WriteLine(store.Data);



            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            kvp1.Key = 100;
            kvp1.Value = "Hundred";
            Console.WriteLine(kvp1.Key + " , " + kvp1.Value);



            DataStores<string> cities = new DataStores<string>();
            cities.AddOrUpdate(1, "cardiff");
            cities.AddOrUpdate(2,"Bristal");
            cities.AddOrUpdate(3, "London");
            Console.WriteLine(cities.GetData(1));

            DataStores<int> empIds = new DataStores<int>();
            empIds.AddOrUpdate(1, 50);
            empIds.AddOrUpdate(2, 65);
            empIds.AddOrUpdate(3, 89);
            Console.WriteLine(empIds.GetData(1));


            Printer printer = new Printer();
            printer.Print<int>(100);
            printer.Print(200); // type infer from the specified value
            printer.Print<string>("Hello");
            printer.Print("World!"); // type infer from the specified value



            Console.WriteLine("===========Generic Constraints==========");
            //C# allows you to use constraints to restrict client code to specify certain types while instantiating generic types.
            //It will give a compile-time error if you try to instantiate a generic type using
            //a type that is not allowed by the specified constraints.

            //You can specify one or more constraints on the generic type using the where clause after the generic type name.

            DataStored<string> sto = new DataStored<string>(); // valid
            sto.Data = "testing";
            Console.WriteLine(sto.Data);
            //DataStored<MyClass> store = new DataStored<MyClass>(); // valid
            //DataStored<IMyInterface> store = new DataStored<IMyInterface>(); // valid
            //DataStored<IEnumerable> store = new DataStored<IMyInterface>(); // valid
            //DataStored<ArrayList> store = new DataStored<ArrayList>(); // valid
            //DataStored<int> store = new DataStore<int>(); // compile-time error




            Console.WriteLine("===========where T : struct==========");
            //The following example demonstrates the struct constraint that restricts type argument
            //to be non-nullable value type only.
            DataStore<int> stor = new DataStore<int>(); // valid
            stor.Data = 12;
            Console.WriteLine(stor.Data);
            // DataStore<char> IMP = new DataStore<char>(); // valid
            //DataStore<MyStruct> store = new DataStore<MyStruct>(); // valid
            //DataStore<string> store = new DataStore<string>(); // compile-time error 
            //DataStore<IMyInterface> store = new DataStore<IMyInterface>(); // compile-time error 
            //DataStore<ArrayList> store = new DataStore<ArrayList>(); // compile-time error 




            Console.WriteLine("===========where T : new()==========");
            //DataStoreNew<MyClass> store = new DataStoreNew<MyClass>(); // valid
            //DataStoreNew<ArrayList> store = new DataStoreNew<ArrayList>(); // valid
            //DataStoreNew<string> store = new DataStoreNew<string>(); // compile-time error 
            //DataStoreNew<int> store = new DataStoreNew<int>(); // compile-time error 
            //DataStoreNew<IMyInterface> store = new DataStoreNew<IMyInterface>(); // compile-time error




            Console.WriteLine("===========where T : baseclass==========");
            //DataStoreBaseclass<ArrayList> storeing = new DataStoreBaseclass<ArrayList>(); // valid
            //DataStoreBaseclass<List> store = new DataStoreBaseclass<List>(); // valid
            //DataStoreBaseclass<string> store = new DataStoreBaseclass<string>(); // compile-time error 
            //DataStoreBaseclass<int> store = new DataStoreBaseclass<int>(); // compile-time error 
            //DataStoreBaseclass<IMyInterface> store = new DataStoreBaseclass<IMyInterface>(); // compile-time error 
            //DataStoreBaseclass<MyClass> store = new DataStoreBaseclass<MyClass>(); // compile-time error
        }
    }
    class DataStore<T>
    {
        public T Data { get; set; }
    }
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }


    //A generic class can include generic fields. However, it cannot be initialized.
    class Data<T>
    {
        public T data;
    }



    //Generic Methods
    class DataStores<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }
        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }
        //overload
        public void AddOrUpdate( string index, T data) { }
        public void AddOrUpdate(T data1, T data2) { }
        public void AddOrUpdate<U>(T data1, U data2) { }
        public void AddOrUpdate(T data) { }
    }



    //A non-generic class can include generic methods
    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }



    //Generic Constraints
    // we applied the class constraint, which means only a reference type can be passed as an argument
    //while creating the DataStored class object.
    //So, you can pass reference types such as class, interface, delegate, or array type.
    //Passing value types will give a compile-time error, so we cannot pass primitive data types or struct types.
    class DataStored<T> where T : class
    {
        public T Data { get; set; }
    }



    //where T : struct
    class DataStoreStruct<T> where T : struct
    {
        public T Data { get; set; }
    }



    //where T : new()
    class DataStoreNew<T> where T : class, new()
    {
        public T Data { get; set; }
    }


    //where T : baseclass
    //The following example demonstrates the base class constraint that restricts type argument
    //be a derived class of the specified class, abstract class, or an interface.
    class DataStoreBaseclass<T> where T : IEnumerable
    {
        public T Data { get; set; }
    }
}
