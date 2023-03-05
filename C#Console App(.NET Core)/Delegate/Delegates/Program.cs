using System;

//What if we want to pass a function as a parameter? How does C# handles the callback functions or event handler?
//The answer is - delegate.

//The delegate is a reference type data type that defines the method signature.
//You can define variables of delegate, just like other data type,
//that can refer to any method with the same signature as the delegate.

//There are three steps involved while working with delegates:
//1-Declare a delegate
//-Set a target method
//3-Invoke a delegate

//Delegate is used to declare an event and anonymous methods in C#

//If a multicast delegate returns a value then it returns the value from the last assigned target method.

//A delegate can be declared outside of the class or inside the class. Practically, it should be declared out of the class.
/*
namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Delegate ========= ");

            //====Set a target method=====
            //MyDelegate del = new MyDelegate(MethodA);
            //or
            //You can set the target method by assigning a method directly without creating an object of delegate e.g.
            MyDelegate del = MethodA;
            // or
            //set lambda expression 
            //MyDelegate del = (string msg) => Console.WriteLine(msg);


            // Invoke a Delegate
            del.Invoke("Hello World!");
            // or 
            //del("Hello World!");
        }

        //====Declare a Delegate!=====
        public delegate void MyDelegate(string msg);
        

        // delegate mehtod
        public static void MethodA(string message)
        {
            Console.WriteLine(message);
        }
    }
   
}
*/
namespace Delegates
{
    // Declare a Delegate
    public delegate void MyDelegate(string msg);
    //Delegate Returning a Value
    public delegate int MyDelegateRV();
    //generic delegate
    public delegate T MyDelegateG<T>(T param1, T param2); 
    class Program
    {
        static void Main()
        {
            Console.WriteLine("============ Delegate ============ ");
            // MethodA
            // set traget
            MyDelegate delA = ClassA.MethodA;
            // invoke delegate
            delA.Invoke("Hello from delegateA");

            // MethodB
            // set traget
            MyDelegate delB = new MyDelegate(ClassB.MethodB);
            // invoke delegate
            delB("Hello from delegateB");

            //Called lambda expression
            delA = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            delA("lambda expression A");
            delB = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            delB("lambda expression B");
            Console.WriteLine("");





            Console.WriteLine("======== Passing Delegate as a Parameter ========");
            static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
            {
                del.Invoke("Hello from Passing Delegate as a Parameter");
            }
            // MethodA
            // set traget
            MyDelegate delC = ClassA.MethodA;
            // invoke delegate
            delC.Invoke("Hello from delegateC");
            // Passing Delegate as a Parameter
            InvokeDelegate(delC);


            // MethodB
            // set traget
            MyDelegate delD = new MyDelegate(ClassB.MethodB);
            // invoke delegate
            delD("Hello from delegateD");
            // Passing Delegate as a Parameter
            InvokeDelegate(delD);
            Console.WriteLine("");




            Console.WriteLine("=========== Multicast Delegate ===========");
            //The delegate can point to multiple methods.
            //A delegate that points multiple methods is called a multicast delegate.
            //The "+" or "+=" operator adds a function to the invocation list,
            //and the "-" and "-=" operator removes it.
            MyDelegate del1 = ClassA.MethodA;
            MyDelegate del2 = ClassB.MethodB;

            MyDelegate del = del1 + del2; // combines del1 + del2
            del("Hello from Multicast Delegate del1 + del2");

            MyDelegate del3 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del += del3; // combines del1 + del2 + del3
            del("Hello from Multicast Delegate del1 + del2 + del3");

            del = del - del2; // removes del2
            del("removes del2");

            del -= del1; // removes del1
            del("removes del1");
            Console.WriteLine("");





            Console.WriteLine("=========== Multicast Delegate Returning a Value ===========");
            ////If a multicast delegate returns a value then it returns the value from the last assigned target method.
            MyDelegateRV del5 = ClassA.MethodH;
            MyDelegateRV del6 = ClassB.MethodM;

            MyDelegateRV del7 = del5 + del6;
            Console.WriteLine(del7());
            Console.WriteLine("");







            Console.WriteLine("=========== Generic Delegate ===========");
            //The generic type must be specified when you set a target method.
            MyDelegateG<int> delG = ClassA.Sum;
            Console.WriteLine(ClassA.Sum(10, 20));

            MyDelegateG<string> delS = ClassB.Concat;
            Console.WriteLine(ClassB.Concat("Hossam", " Farfour"));
            Console.WriteLine("");


        }

    }
    public class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
        //Multicast Delegate Returning a Value
       public static int MethodH()
        {
            return 100;
        }
        // genaric Delegate
        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }
    }
    public class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
        //Multicast Delegate Returning a Value
        public static int MethodM()
        {
            return 300;
        }
        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}