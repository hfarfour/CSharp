using System;


//In C#, static means something which cannot be instantiated.
//You cannot create an object of a static class and cannot access static members using an object.


//1-Static classes cannot be instantiated.
//2-All the members of a static class must be static; otherwise the compiler will give an error.
//3-A static class can contain static variables, static methods, static properties, static operators, static events, and static constructors.
//4-A static class cannot contain instance members and constructors. (all members and mehtod must be static)
//5-Indexers and destructors cannot be static
//6-var cannot be used to define static members.You must specify a type of member explicitly after the static keyword.
//7-Static classes are sealed class and therefore, cannot be inherited.
//8-A static class cannot inherit from other classes.
//9-Static class members can be accessed using ClassName.MemberName.
//10-A static class remains in memory for the lifetime of the application domain in which your program resides.


namespace Static
{
    class Program
    {
        static void Main()
        {
            // static class access
            //You cannot create an object of the static class;
            //therefore the members of the static class can be accessed directly using a class name like ClassName.MemberName.
            var result = Calculator.Sum(12,12); // calling static method
            Console.WriteLine(result);
            var calcType = Calculator.Type; // accessing static variable
            Calculator.Type = "Scientific";
            Console.WriteLine(calcType);
            Console.WriteLine(Calculator.Type);




            // non-static class access
            //Static fields of a non-static class is shared across all the instances.
            //So, changes done by one instance would reflect in others.
            StopWatch sw1 = new StopWatch();
            StopWatch sw2 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances); //print 2 

            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);// print 4




            //You can define one or more static methods in a non-static class.
            //Static methods can be called without creating an object.
            //You cannot call static methods using an object of the non-static class.

            //The static methods can only call other static methods and access static members.
            //You cannot access non-static members of the class in the static methods.
            counter++; // can access static fields
            static void display(string text)
            {
                Console.WriteLine(text);
            }
            display("hello world");
            // name = ("New Demo name");//compile time error . cannot access non static members
            //setRootFolder("c:\myprograam");//compile time error . cannot access non static members.


            // Static Constructor vs Instance Constructor
           // Stop.DisplayInfo(); // static constructor called here
           // Stop.DisplayInfo(); // none of the constructors called here
            
            Stop sw5 = new Stop(); // First static constructor and then instance constructor called 
            Stop sw6 = new Stop();// only instance constructor called 
            
            Stop.DisplayInfo();
            //Static constructor will be executed only once in the lifetime.
            //So, you cannot determine when it will get called in an application if a class is being used at multiple places.
           // A static constructor can only access static members.It cannot contain or access instance members.
        }


        static int counter = 0;
        string name = "demo program";
        public void setRootFolder() // non static 
        {

        }
    }

    // static class
    public static class Calculator
    {
        public static string Type = "Arithmetic";
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    // non-static class
    public class StopWatch
    {
        public static int NoOfInstances = 0;
        // instance constructor
        public StopWatch()
        {
            StopWatch.NoOfInstances++;
        }
    }

    // Static Constructor vs Instance Constructor
    public class Stop
    {
        // static constructor
        static Stop()
        {
            Console.WriteLine("Static constructor called");
        }

        // instance constructor
        public Stop()
        {
            Console.WriteLine("Instance constructor called");
        }
        // static method
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }
        public void Start() { }// instance method
        public void Stoped() { }// instance method
    }


}

//1-Static methods can be defined using the static keyword before a return type and after an access modifier.
//2-Static methods can be overloaded but cannot be overridden.
//3-Static methods can contain local static variables.
//4-Static methods cannot access or call non-static variables unless they are explicitly passed as parameters