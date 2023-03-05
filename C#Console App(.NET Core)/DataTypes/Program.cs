using System;
using static System.String;
using System.Collections; // to sue list
using System.Collections.Generic; // to sue list
using System.IO;// to use file
using System.Linq;
using System.Text; // to sue stringBuilder


//Referance type {Class , array , Delegate} 
//    Value type {Enum , struct , Nullable type}



//Value type are : bool /byte /char /decimal /double /enum /float /int /long /sbyte /short /struct /uin t/ulong /ushort
// Referance Type : String / Arrays(even if their elements are value types) / Class / Delegate



// == compare referance
// d1.Equal(d2); compare content

//int h = nul; // can not assign null to value //so use instead = 0;
//Console.WriteLine(h);

//byte 8-bit unsigned integer	0 to 255	
//sbyte 8-bit signed integer	-128 to 127	
//short	16-bit signed integer	-32,768 to 32,767	
//ushort 16-bit unsigned integer	0 to 65,535	
//int 32-bit signed integer	-2,147,483,648 to 2,147,483,647
//byte 8 bit
//short 16 bit
//int 32 bit
//long 64 bit
//float 32 bit
//decimal 128 bit

//the string type is immutable. It means a string cannot be changed once created..changing the string would
//woyld hinder the proformance if the orginal string changed multiblt times So to handle this issue us StringBuilder
//The StringBuilder doesn't create a new object in the memory but dynamically expands memory
//to accommodate the modified string.//using System.Text; // include at the top
namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======Var=========");
            int I = 100; // this is explicitly type vatiable
            var j = 100; // this is implicitly type variable here var is Int (check the value)

            // Implicitly - typed variables must be initialized at the time of declaration
            // var t; // comile time error
            // t = 100;

            var f = 10;
            Console.WriteLine("Type of i is {0}", f.GetType());

            var str = "Hello World!";
            Console.WriteLine("Type of str is {0}", str.GetType());

            var dbl = 100.50d;
            Console.WriteLine("Type of dbl is {0}", dbl.GetType());

            var isValid = true;
            Console.WriteLine("Type of isValid is {0} ", isValid.GetType());

            var ano = new { name = "Steve" };
            Console.WriteLine("Type of ano is {0}", ano.GetType());

            var arr = new[] { 1, 10, 20, 30 };
            Console.WriteLine("Type of arr is {0}", arr.GetType());

            var file = new FileInfo("MyFile");
            Console.WriteLine("Type of file is {0}", file.GetType());


            //var cannot be used for function parameters.
            //void Display(var param) //Compile-time error
            //{
            //    Console.Write(param);
            //}
            //cannot use var with array initializer and in function parameter
            // var evenNums = { 2, 4, 6, 8, 10 };

            //var can be used in for, and foreach loops.
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("===========String in LINQ queries.==========");
            //var can also be used with LINQ queries.
            IList<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
              };

            // LINQ Query Syntax
            Console.WriteLine("=======LINQ Query Syntax======");
            var result = from s in stringList
                         where s.Contains("Tutorials")
                         select s;
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("====Creating a StringBuilder Object====");
            //StringBuilder is mutable.
            //1-StringBuilder performs faster than string when appending multiple string values.
            //2-Use StringBuilder when you need to append more than three or four strings.
            //3-Use the Append() method to add or append strings to the StringBuilder object.
            //Use the ToString() method to retrieve a string from the StringBuilder object.

            StringBuilder sb = new StringBuilder("Hello World!"); //string will be appended later
            //or
            //StringBuilder sb = new StringBuilder("Hello World!", 50);
            //allocates a maximum of 50 spaces sequentially on the memory heap.
            //This capacity will automatically be doubled once it reaches the specified capacity.
            //You can also use the capacity or length property to set or retrieve the StringBuilder object's capacity.
            for (int i = 0; i < sb.Length; i++)
                Console.WriteLine(sb[i]);


            Console.WriteLine("====Retrieve String from StringBuilder====");
            var greet = sb.ToString();
            Console.WriteLine(greet);



            Console.WriteLine("====Add/Append String to StringBuilder====");
            //Use the Append() method to append a string at the end of the current StringBuilder object.
            //If a StringBuilder does not contain any string yet, it will add it.
            //The AppendLine() method append a string with the newline character at the end.
            StringBuilder sbt = new StringBuilder("Hello ");
            sbt.Append("World!!");
            sbt.AppendLine("Hello C#!");
            sbt.AppendLine("This is new line.");
            Console.WriteLine(sbt);


            Console.WriteLine("====Append Formated String to StringBuilder====");
            //Use the AppendFormat() method to format an input string into the specified format and append it.
            StringBuilder sbAmout = new StringBuilder("Your total amount is ");
            sbAmout.AppendFormat("{0:C}", 25);// print £25.00
            Console.WriteLine(sbAmout);



            Console.WriteLine("=====Insert String into StringBuilder==========");
            //Use the Insert() method inserts a string at the specified index in the StringBuilder object.
            StringBuilder sbd = new StringBuilder("Hello World!");
            sbd.Insert(5, " C#"); //print Hello C# World!"
            Console.WriteLine(sbd);



            Console.WriteLine("=====Remove String in StringBuilder==========");
            StringBuilder sbh = new StringBuilder("Hello World!!");
            sbh.Remove(6, 7); // 6 is start index 7 the number of index to remove
            Console.WriteLine(sbh);



            Console.WriteLine("=====Replace String in StringBuilder==========");
            //Use the Replace() method to replace all the specified string occurrences with the specified replacement string.

            StringBuilder sbx = new StringBuilder("Hello World!!", 50);
            sbx.Replace("World", "C#");
            Console.WriteLine(sbx);



            Console.WriteLine("=====?. and ?? ==========");
            Person p = new Person();
            p.FistName = null;
            p.Lastname = " Farfour";
            var name = p?.FistName ?? "unkown" + p?.Lastname;
            Console.WriteLine(name);
            //The ?. is called the null conddition operator which check for null.
            //the ?? is called the null coalescing operator to assign default values
            //when one of the poerator is null



            IList numbers = null;
            Console.WriteLine(numbers?[0]); // return null if the left-hand operator evaluates to null

            Console.WriteLine("===============");

            int x = default;
            Console.WriteLine(x); // print 0

            Console.WriteLine("=======char of string========");
            //string st = "Hello"; uses string keyword
            //String st = "Hello"; uses System.String class
            char[] chars = { 'H', 'e', 'l', 'l', 'o' };

            string str1 = new string(chars);
            String str2 = new String(chars);
            foreach (char c in str1)
            {
                Console.WriteLine(c);
            }


            // @prefix \ to include every special characters
            Console.WriteLine("=======@prefix========\n");
            string ste = @"xyzdef\rabc";
            string path = @"\\mypc\shared\project";
            string email = @"test@test.com";
            Console.WriteLine(ste);
            Console.WriteLine(path);
            Console.WriteLine(email);

            //The @ symbol can also be used to declare a multi - line string.
            string str3 = "this is a \n" +
            "multi line \n" +
            "string";
            Console.WriteLine(str3);

            string str4 = @"this is a  //@inclue spaces
 multi line 
 string";
            Console.WriteLine(str4);


            // ===String Interpolation====
            Console.WriteLine("======String Interpolation $ =========");
            //String interpolation is a better way of concatenating strings.
            //We use + sign to concatenate string variables with static strings.

            //C# 6 includes a special character $ to identify an interpolated string.
            //An interpolated string is a mixture of static string and string variable
            //where string variables should be in {} brackets.

            string firstName = "James";
            string lastName = "Bond";
            string code = "007";
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}"; // takes pracket off
            Console.WriteLine(fullName);


            //=================DateTime=================
            Console.WriteLine("======DateTime=========");
            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();
            Console.WriteLine(dt1);

            //assign year, month, day
            DateTime dt2 = new DateTime(1990, 01, 01);
            Console.WriteLine(dt2);

            //assign year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(1990, 01, 01, 10, 30, 59);
            Console.WriteLine(dt3);

            //assign year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Local);
            Console.WriteLine(dt4);

            //currrent date time
            DateTime dt5 = DateTime.Now;
            Console.WriteLine(dt5);

            DateTime dt6 = DateTime.Today;
            Console.WriteLine(dt6);
            // to check max date time
            DateTime dt7 = DateTime.MaxValue;
            Console.WriteLine(dt7);
            // to check min date time
            DateTime dt8 = DateTime.MinValue;
            Console.WriteLine(dt8);

            // TimeSpan // subtract of two date // print in how many days
            DateTime dt9 = new DateTime(2023, 01, 18);
            DateTime dt10 = new DateTime(1990, 01, 01);
            TimeSpan Result = dt9.Subtract(dt10);
            Console.WriteLine(Result);
            //or
            Console.WriteLine(dt9 - dt10);
            Console.WriteLine(dt9 == dt10);

            //get differeant bwteen two dates.
            var prevdate = new DateTime(1990, 01, 01);
            var today = DateTime.Now;
            var differant = today - prevdate;
            Console.WriteLine("the Differant bwteen two dates is {0} ", differant.Days);


            Console.WriteLine("======convert string to dateTime=========");
            // A valid date and time string can be converted to a DateTime object using
            // Parse(), ParseExact(), TryParse() and TryParseExact() methods.
            //The Parse() and ParseExact() methods will throw an exception if the specified
            //string is not a valid representation of a date and time.
            //So, it's recommended to use TryParse() or TryParseExact() method because they return false if a string is not valid.
            var k = "5/12/2020";
            DateTime dt11;

            var isValidDate = DateTime.TryParse(k, out dt11); //causes argumrnt to be passed by referance
            if (isValidDate)
                Console.WriteLine(dt11);
            else
                Console.WriteLine($"{k} is not a valid date string");


            Console.WriteLine("======Boxing and Unboxing=========");
            // boxing is the process of converting a value type to the refernce type ,vice versa
            // unboxing
            object val = 123;
            int z = (int)val;
            Console.WriteLine(z);

            Console.WriteLine("======ref // pass by refreance=========");
            int somename = 12;
            change(ref somename);
            Console.WriteLine(somename);
            static void change(ref int d)
            {
                d = 10;
            }

            // can not convert object to string So must de converted explicitly string s1 = (string) Q;
            // object Q = "hello";
            //string s1 = Q;
            // Console.WriteLine(s1);




            //int h = nul; // can not assign null to value //so use instead = 0;
            //Console.WriteLine(h);


            Console.WriteLine("======Difference between Ref and Out keywords in=========");
            // ref is used to state that the parameter passed may be modified by the method. use when update parameter
            // in is used to state that the parameter passed cannot be modified by the method. use when update multi parameter
            // out is used to state that the parameter passed must be modified by the mehtod.
            //out // can use withput initilasting
            int G;
            Sum(out G);
            Console.WriteLine("The sum of" + " the value is: {0}", G);

            static void Sum(out int G)
            {
                G = 80;
                G += G;
            }

            //ref // must be inifilized before use
            string str12 = "Geek";
            SetValue(ref str12);
            Console.WriteLine(str12);

            static void SetValue(ref string str1)
            {
                if (str1 == "Geek")
                {
                    Console.WriteLine("Hello!!Geek");
                }
                str1 = "GeeksforGeeks";
            }


            Console.WriteLine("======{0},{1} It's a placeholder for the first parameter=======");

            string b = "world.";
            //string a = String.Format("Hello {0}", b);
            Console.WriteLine("Hello {0}", b);




            Console.WriteLine("======Anonymous Type=======");
            //1-an anonymous type is a type (class) without any name that can contain public read-only properties only.
            //2-It cannot contain other members, such as fields, methods, events, etc.
            //3-You create an anonymous type using the new operator with an object initializer syntax.
            //The implicitly typed variable- var is used to hold the reference of anonymous types.
            //4-The properties of anonymous types are read-only and cannot be initialized with a null
            //5-cannot change the values of properties as they are read-only
            var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            // student.Id = 2;//Error:   // cannot chage value
            //student.FirstName = "Steve";


            //An anonymous type's property can include another anonymous type.
            var Employee = new
            {
                Id = 1,
                FirstName = "Soubhi",
                LastName = "Farfour",
                Address = new { FNumber = 58, Strret = "Clos Dwei sant", City = "Cardiff", Country = "UK" }
            };
            Console.WriteLine(Employee.Id);
            Console.WriteLine(Employee.FirstName);
            Console.WriteLine(Employee.LastName);
            Console.WriteLine($"Employee address is { Employee.Address}");


            // Array of Anonymous Types
            var Worker = new[]
            { new {Id = 1 , FirstName = "Dalal" , LastName = "Yousef" },
              new {Id = 2 , FirstName = "Adial" , LastName = "Ahmed" },
              new {Id = 3 , FirstName = "Tasee" , LastName = "Toooes" },
            };
            Console.WriteLine($"Employee Details are { Worker[1]}");
            Console.WriteLine("Employee Details are ");
            for (int i = 0; i < Worker.Length; i++)
            {
                Console.WriteLine(Worker[i]);
            }


            //LINQ Query returns an Anonymous Type
            //Mostly, anonymous types are created using the Select clause of a LINQ queries to return
            //a subset of the properties from each object in the collection.
            IList<Student> StudentList = new List<Student>()
            {
                new Student() {StudentId = 1 , Student_FirstName = "John",Student_LastName = "User1" },
                new Student() {StudentId = 2 , Student_FirstName = "Steve",Student_LastName = "User2" },
                new Student() {StudentId = 3 , Student_FirstName = "Bill",Student_LastName = "User3" },
                new Student() {StudentId = 4 , Student_FirstName = "Ram",Student_LastName = "User4" },
                new Student() {StudentId = 5 , Student_FirstName = "Ron",Student_LastName = "User5" }
            };
            // LINQ Query
            var Details = from s in StudentList
                          select new
                          {
                              Id = s.StudentId,
                              firstName = s.Student_FirstName,
                              lastNmae = s.Student_LastName

                          };

            foreach (var s in StudentList)
            {
                Console.WriteLine($"stduent: {s.StudentId} { s.Student_FirstName} { s.Student_LastName}");
            }

            //Internally, all the anonymous types are directly derived from the System.Object class.
            //The compiler generates a class with some auto-generated name and applies the appropriate type to each property based on the value expression.
            //Although your code cannot access it. Use GetType() method to see the name.
            var stu = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.WriteLine(stu.GetType()); //print System.Int32,System.String,System.String]





            Console.WriteLine("======Dynamic type=======");
            // A dynamic type escapes type checking at compile-time; instead, it resolves type at run time
            //The compiler compiles dynamic types into object types in most cases.
            //However, the actual type of a dynamic type variable would be resolved at run-time.
            dynamic MyDynamicVar = "test";
            Console.WriteLine(MyDynamicVar.GetType());
            //Dynamic types change types at run-time based on the assigned value.
            //The following example shows how a dynamic variable changes type based on assigned value.
            dynamic MyDynamic = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamic, MyDynamic.GetType());
            MyDynamic = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamic, MyDynamic.GetType());
            MyDynamic = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamic, MyDynamic.GetType());
            MyDynamic = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamic, MyDynamic.GetType());
            Console.WriteLine("");
            //
            //SomeStudent stud = new SomeStudent(); this way takes onlt int id
            //stud.DisplayStudentInfo(1, "Hossam"); compile time erreo
            SomeStudent stud = new SomeStudent();
            dynamic sd = stud;
            sd.DisplayStudentInfo(1);

            //Methods and Parameters:
            //If you assign a class object to the dynamic type, then the compiler would not check for correct methods
            //and properties name of a dynamic type that holds the custom class object. 

            //sd.DisplayStudentInfo(1, "Bill");// run-time error, no compile-time error
            //sd.DisplayStudentInfo("1");// run-time error, no compile-time error
            //sd.FakeMethod();// run-time error, no compile-time error



            Console.WriteLine("======Nullable Types=======");
            //As you know, a value type cannot be assigned a null value.
            //For example, int i = null will give you a compile time error.

            // nullable types that allow you to assign null to value type variables.
            //You can declare nullable types using Nullable<t> where T is a type.

            //The Nullable types are instances of System.Nullable<T> struct

            //Nullable types can only be used with value types.
            Nullable<int> t = null;
            if (t.HasValue)
                Console.WriteLine(t.Value); // or Console.WriteLine(i)
            else
                Console.WriteLine(" the value is Null");

            Nullable<int> g = null;
            //Console.WriteLine(g.Value); //run time error
            //Use the GetValueOrDefault() method to get an actual value if it is not null
            //and the default value if it is null. For example
            Nullable<int> D = 10;
            Console.WriteLine(D.GetValueOrDefault());

            //Shorthand Syntax for Nullable Types
            //You can use the '?' operator to shorthand the syntax e.g. int?, long? instead of using Nullable<T>
            int? X = null;
            double? Z = null;
            Console.WriteLine(Z.GetValueOrDefault());
            //Use the '??' operator to assign a nullable type to a non-nullable type
            double C = Z ?? 9;
            Console.WriteLine(C);
            //In the above example, i is a nullable int and if you assign it to the non-nullable int j
            //then it will throw a runtime exception if i is null. So to mitigate the risk of an exception,
            //we have used the '??' operator to specify that if i is null then assign 0 to j.


            // Assignment Rules
            //It must be assigned a value before using it if nullable types are declared in a function as local variables.
            //If it is a field of any class then it will have a null value by default.
            //Nullable<int> DJ;
            //Console.WriteLine(DJ.GetValueOrDefault()); // compile time error // must be assigned
            MyClass mycls = new MyClass();
            // mycls.BB = 56;
            if (mycls.BB == null) // can only use == or != with class Nullable oprtator
                Console.WriteLine("value is Null");
            else
                Console.WriteLine(mycls.BB);



            // Nullable Helper Class
            //Null is considered to be less than any value. So comparison operators won't work against null
            int? M = null;
            int N = 10;
            if (M < N)
                Console.WriteLine("M < N");
            else if (M > 10)
                Console.WriteLine("M > N");
            else if (M == 10)
                Console.WriteLine("M == N");
            else
                Console.WriteLine("Could not compare Null value ");
            //Nullable static class is a helper class for Nullable types. It provides a compare method to compare nullable types.
            //It also has a GetUnderlyingType method that returns the underlying type argument of nullable types.
            if (Nullable.Compare<int>(M, N) < 0)
                Console.WriteLine("M < N");
            else if (Nullable.Compare<int>(M, N) > 0)
                Console.WriteLine("M > N");
            else
                Console.WriteLine("M = N");
            //1-Nullable types can only be used with value types.
            //2-The Value property will throw an InvalidOperationException if value is null;
            //otherwise it will return the value.
            //3-The HasValue property returns true if the variable contains a value, or false if it is null.
            //4-You can only use == and != operators with a nullable type. For other comparison use the Nullable static class.
            //5-Nested nullable types are not allowed. Nullable<Nullable<int>> i; will give a compile time error.

            // remeber
            // Nullable<T> type allows assignment of null to value types.
            //  ? operator is a shorthand syntax for Nullable types.
            //Use value property to get the value of nullable type.
            //Use HasValue property to check whether value is assigned to nullable type or not.
            //Static Nullable class is a helper class to compare nullable types.



            Console.WriteLine("=========Value Type=========");
            //When you pass a value-type variable from one method to another, the system creates a separate copy of a variable in another method.
            //If value got changed in the one method, it wouldn't affect the variable in another method.
            static void ChangeValue(int x)
            {
                x = 200;
                Console.WriteLine(x);
            }
                int V = 100;
                Console.WriteLine(V);
                ChangeValue(V);
                Console.WriteLine(V);





            Console.WriteLine("=========Reference Type=========");
            //Unlike value types, a reference type doesn't store its value directly.
            //Instead, it stores the address where the value is being stored.
            //In other words, a reference type contains a pointer to another memory location that holds the data.
           static void ChangeReferenceType(Student std2)
            {
                std2.Student_FirstName = "Steve";
            }
            Student std1 = new Student();
            std1.Student_FirstName = "Bill";
            ChangeReferenceType(std1);
            Console.WriteLine($"student name is now : {std1.Student_FirstName}");



            Console.WriteLine("=========String Type=========");
            //String is a reference type, but it is immutable. It means once we assigned a value,it cannot be changed.
            //If we change a string value, then the compiler creates a new string object in the memory and point a variable to the new memory location.
            //So, passing a string value to a function will create a new variable in the memory, 
            //and any change in the value in the function will not be reflected in the original value.
            static void ChangeStringeType(string name)
            {
                name = "tested";
               // Console.WriteLine(name);
            }
            string Name = "NewName";
            ChangeStringeType(Name);
            Console.WriteLine(Name);




            Console.WriteLine("=========Null=========");
            //The default value of a reference type variable is null when they are not initialized.
            //Null means not refering to any object.
            //A value type variable cannot be null because it holds value, not a memory address.
        }
    }
    //end main===========================================================================
    class Person
    {
        public string FistName { get; set;}
        public string Lastname { get; set;}
    }


    // for LINQ Query in Anonymous Type
    class Student
    {
        public int StudentId { get; set; }
        public string Student_FirstName{ get; set; }
        public string Student_LastName { get; set; }
    }


    //Dynamic type calss
    public class SomeStudent
    {
        public void DisplayStudentInfo(int id)
        {
            Console.WriteLine("Dummy Student");
        }
    }
    // for Nullable // default value is 0 because it is declareed inside a class 
    class MyClass
    {
        public Nullable<int> BB;
    }
}
