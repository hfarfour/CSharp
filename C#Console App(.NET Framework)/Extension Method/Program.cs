using System;
using ExtensionMethods;

//Extension methods allow you to inject additional methods without modifying,
//deriving or recompiling the original class, struct or interface.

//Extension methods can be used anywhere in the application by including the namespace of the extension method.

//
namespace Extension_Method
{
    class Program
    {
        static void Main()
        {
            int i = 10;
            bool results = i.IsGreaterThan(100);
            Console.WriteLine(results);
        }
    }
}

// Now, define a static method as an extension method where the first parameter of the extension method
//specifies the type on which the extension method is applicable.
//We are going to use this extension method on int type.
//So the first parameter must be int preceded with the this modifier.

//An extension method is actually a special kind of static method defined in a static class.
//To define an extension method, first of all, define a static class.
namespace ExtensionMethods
{
    public static class IntExtensions
    {
        // return fales or true
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
