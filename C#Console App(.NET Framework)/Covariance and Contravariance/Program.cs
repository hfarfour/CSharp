using System;

//A- Covariance and contravariance allow us to be flexible when dealing with class hierarchy.
//B- a base class can hold a derived class but a derived class cannot hold a base class

//Covariance enables you to pass a derived type where a base type is expected.
//The base class and other derived classes are considered to be the same kind of class that adds extra functionalities to the base type.
//So covariance allows you to use a derived class where a base class is expected (rule: can accept big if small is expected).

namespace Covariance_and_Contravariance
{
    //Covariance with Delegate
    public delegate Small CovarianceDelegte(Big mc);
    class Program
    {
        static void Main()
        {
            //=======Covariance======
            //Covariance in delegates allows flexiblity in the return type of delegate methods.
            CovarianceDelegte del = Method1;
            Small sm1 = del(new Big());

            del = Method2;
            Small sm2 = del(new Big());
            Console.WriteLine(" ");
            //As you can see in the above example,
            //delegate expects a return type of small (base class) but we can still assign Method1
            //that returns Big (derived class) and also Method2 that has same signature as delegate expects.

            //=======Contravariance======
            //Contravariance is applied to parameters.
            //Contravariance allows a method with the parameter of a base class to
            //be assigned to a delegate that expects the parameter of a derived class.

            del = Method3;
            Small ms3 = del(new Big());
            Console.WriteLine(" ");

            //or
            CovarianceDelegte de2 = Method1;
            de2 += Method2;
            de2 += Method3;
            de2 += Method4;
            Small sm = de2(new Big());
            //As you can see, Method3 has a parameter of Small class whereas delegate expects a parameter of Big class.
            //Still, you can use Method3 with the delegate.
            Console.WriteLine(" ");


            //======= You can also use covariance and contravariance in the same method as shown below======
            CovarianceDelegte de3 = Method4;
            Small SUM = de3(new Big());
        }

        //Covariance with Delegate
        public static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");
            return new Big();
        }
        public static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");
            return new Small();
        }
        //Continuing with the example above, add Method3 and Method4 that has a different parameter type than delegate:
        public static Small Method3(Small sml)
        {
            Console.WriteLine("Method3");
            return new Small();
        }
        public static Bigger Method4(Small sml)
        {
            Console.WriteLine("Method4");
            return new Bigger();
        }

    }
    public class Small
    {

    }
    public class Big : Small
    {

    }
    public class Bigger : Big
    {

    }
}
