using System;


// includes built-in generic delegate types Func and Action,
//so that you don't need to define custom delegates manually in most cases.

//Func delegate type must return a value
//Action delegate type does not return a value // must be void

//An Action and Func delegate can take up to 16 input parameters of different types

//Action and Func delegate can be used with anonymous methods or lambda expressions.
namespace Function_Delegate
{
    class Program
    {
        //func Delegate
        public delegate TResult Func<in T, out TResult>(T arg);
        static Func<int, int, int> operations;
        // Action Delegate
        public delegate void Print(int val);
        //Predicate Delegate
        public delegate bool PredicateDelegate<in T>(T obj);
        // Anonymous Method
        public delegate void PrintAnonymous(int value);
        static void Main()
        {
            //Func is a generic delegate included in the System namespace.
            //It has zero or more input parameters and one out parameter.
            //The last parameter is considered as an out parameter.

            Console.WriteLine("============== func Delegate ===============");
            static int sum(int x, int y)
            {
                return x + y;
            }
            Func<int, int, int> add = sum;  //func Delegate
            int result = add(10, 10);
            Console.WriteLine(result); //print 20


            Console.WriteLine("=== Func with Zero Input Parameter ====");
            //A Func delegate type can include 0 to 16 input parameters of different types.
            //However, it must include an out parameter for the result.
            //For example, the following Func delegate doesn't have any input parameter,
            Func<int> getRandomNumberd;



            Console.WriteLine("==== Func with an Anonymous Method ====");
            Func<int> getRandomNumbers = delegate()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };
            int test =  getRandomNumbers();
            Console.WriteLine(test);


            Console.WriteLine("===== Func with Lambda Expressio ====");
            Func<int> getRandomNumber = () => new Random().Next(1, 100);
            Func<int, int, int> Sum = (x, y) => x + y;
            Console.WriteLine(getRandomNumber());
            Console.WriteLine(Sum(10, 20));
            Console.WriteLine("================================================================");







            Console.WriteLine("============ Action Delegate ============");
            static void ConsolePrint(int i) //must be void 
            {
                Console.WriteLine(i);
            }
            Print prnt =  ConsolePrint;
            prnt.Invoke(10);

            //You can use an Action delegate instead of defining the above Print delegate, for example:
            Action<int> printActionDel = ConsolePrint;
            printActionDel(20);

            //You can initialize an Action delegate using the new keyword or by directly assigning a method:
            Action<int> printActionDels = new Action<int>(ConsolePrint);
            printActionDels(30);

            //An Anonymous method can also be assigned to an Action delegate
            Action<int> printAction = delegate (int i)
            {
                Console.WriteLine(i);
            };
            printAction(40);

            //A Lambda expression also can be used with an Action delegate:
            Action<int> printActionLamp = i => Console.WriteLine(i);
            printActionLamp(50);
            Console.WriteLine("================================================================");








            Console.WriteLine("============ Predicate Delegate ===========");
            //Predicate is the delegate like Func and Action delegates.
            //It represents a method containing a set of criteria and checks whether the passed parameter meets those criteria.
            //A predicate delegate methods must take one input parameter and return a boolean - true or false
            static bool predicats(string str) // must be bool
            {
                return str.Equals(str.ToUpper());
            }
            Predicate<string> isUpper = predicats;
            bool results = isUpper("Hello !!");
            Console.WriteLine(results);

            ////You can use an Predicate delegate instead of defining the above predicats delegate, for example:
            Predicate <string> stringPrecicate = predicats;
            bool s =  stringPrecicate("ISSA");
            Console.WriteLine(s);

            // You can initialize predicate delegate using the new keyword or by directly assigning a method:
            Predicate<string> printPredicate = new Predicate<string>(predicats);
            bool tested = printPredicate.Invoke("hossam");
            Console.WriteLine(tested);

            //An anonymous method can also be assigned to a Predicate delegate type.
            Predicate<string> isUppered = delegate (string s)
            {
                return s.Equals(s.ToUpper());
            };
            bool resulted = isUppered("hello world!!");
            Console.WriteLine(resulted);

            //  //A Lambda expression also can be used with an Action delegate:
            Predicate<string> printPredicateLamp = s => s.Equals(s.ToUpper());
           bool g =  printPredicateLamp("YILDIZ");
            Console.WriteLine(g);
            Console.WriteLine("================================================================");










            Console.WriteLine("============ Anonymous Method ===========");
            //an anonymous method is a method without a name.
            //Anonymous methods in C# can be defined using the delegate keyword
            //and can be assigned to a variable of delegate type.
            PrintAnonymous print = delegate (int val)
            {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };
            print.Invoke(100);


            // Anonymous Method
            //Anonymous methods can access variables defined in an outer function.
            int i = 20;
            PrintAnonymous p = delegate (int val) 
            {
                val += i;
                Console.WriteLine("Anonymous method: {0}", val);
            };
            p(100);


            //Anonymous methods can also be passed to a method that accepts the delegate as a parameter.
             static void PrintHelperMethod(PrintAnonymous printDel, int val)
            {
                val += 10;
                printDel(val);
            }
            PrintHelperMethod(delegate (int val)
            { Console.WriteLine("Anonymous method: {0}", val); }, 100);
            

        }
    }
}
