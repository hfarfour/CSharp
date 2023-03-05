using System;
using School;
using School.Education;



// struct can be used to hold small data values that do not require inheritance.
//A struct object can be created with or without the new operator.

//If you declare a variable of struct type without using new keyword,it does not call any constructor,
//so all the members remain unassigned.Therefore, you must assign values to each member before accessing them,
//otherwise, it will give a compile-time error.

//A struct cannot contain a parameterless constructor.
//It can only contain parameterized constructors or a static constructor.

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student()
            //{
            //    FistName = "Hossam",
            //    LastName = "Farfour",
            //    StudentID = 12345,
            //};
            //or
            Student student1 = new Student();
            student1.FistName = "Issa";
            student1.LastName = "Farfour";
            student1.StudentID = 13455;

            Console.WriteLine("===== auto-implemented methods======");
            Console.WriteLine(student1.getFullNmae());
            Console.WriteLine(student1.StudentID);
            int num1 = 12;
            int num2 = 12;
            Console.WriteLine(student1.Sum(num1, num2));


            // School namespace
            School.student std = new School.student();
            School.course co = new School.course();
            // to avoid full declration i can add using School at the top
            // Like
            student std1 = new student();
            course co1 = new course();

            StudentsList list = new StudentsList();


            Console.WriteLine("=====struct with new operator");
            // x and y cordination 
            Coordinate point = new Coordinate();
            Console.WriteLine(point.x); // print 0
            Console.WriteLine(point.x); // print 0

            //Coordinate poin = new Coordinate();
            //poin._x = 10;
            //poin.y = 10;
            //Console.WriteLine(poin._x); // print 0
            //Console.WriteLine(poin.y); // print 0
            Console.WriteLine("=====struct without new operator======");
            Employee Emp1;
            //Console.WriteLine(Emp1.EmpId); // compile-time error. because new not used so there is no constructor been calleed
            Emp1.EmpId = 30008722;
            Emp1.FirstName = "Hoosam";
            Emp1.LastName = "Farfour";
            Console.WriteLine( $"Employee name is { Emp1.FirstName} { Emp1.LastName}");


            Console.WriteLine("=====struct with constructor======need new");
            //struct with constructor .. new needed to call the constructor
            //You must include all the members of the struct in the parameterized constructor
            //and assign parameters to members otherwise will get error
            Employee Emp2 = new Employee(1990, "Issa", "farfour");
            Emp2.EmpDetalis();// method to print all details


            Employee Emp3 = new Employee(1959, "Dala", "farfour");
            Console.WriteLine(Emp3.EmpId);
            Console.WriteLine(Emp3.FirstName);
            Console.WriteLine(Emp3.LastName);


            Console.WriteLine("=====call static method======");
            Employee get = Employee.GetTest();//with static no needd for new operator
            get.EmpId = 1991;
            get.FirstName = "Hasna";
            get.LastName = "farfour";
            Console.WriteLine(get.EmpId);
            Console.WriteLine(get.FirstName);
            Console.WriteLine(get.LastName);


            Console.WriteLine("=====Events in Structure======");
            // when I have private mebers must include new to access variables.
            //A struct can contain events to notify subscribers about some action.
            //The following example demonstrates the handling of the CoordinatesChanged event.
            worker work = new worker();
            work.workerInt += StructEventHandler; // for int
            work.x = 10;
            work.workerString += StructEventHandler; // for string
            work.y = "Yildiz";
            work.z = "Farfour";

            work.x = 20;
            work.y = "Daniz";
            work.z = "Farfur";
        }
        static void StructEventHandler(int point)
        {
            Console.WriteLine("Coordinate int changed to {0}", point);
        }
        static void StructEventHandler(string point)
        {
            Console.WriteLine("Coordinate string changed to {0}", point);
        }
    }
    //end main==========================================================================
    struct Student
    {
        private int ID; // this is field
        public int StudentID // this is property to assign and retrieve underlying field value. 
        {
            get { return ID; }
            set
            {
                if (value > 0)
                    ID = value;
            }
        }
        //A struct can contain properties, auto-implemented properties, methods, same as classes.
        //C# compiler will automatically create it in IL code
        public string FistName { get; set; }
        public string LastName { get; set; }

        // meoth to get full name
        public string getFullNmae()
        {
            return FistName + " " + LastName;
        }

        //// meoth to get the sum 
        public int Sum(int num1, int num2)
        {
            var total = num1 + num2;
            return total;
        }
    }
    struct Coordinate
    {
        public int x;
        public int y;
        // does needd new operator t access these vriables.
        //private int x;
        //private int y;
        //public int _x
        //{
        //    get { return x; }
        //    set { x = value; }
        //}
        //public int _y
        //{
        //    get { return y; }
        //    set { y = value; }
        //}
    }
    struct Employee
    {
        // this is constrctor (can not be parameterless);
        public Employee(int id,string n, string l)
       {
            EmpId = id;
            FirstName = n;
            LastName = l;
       }
        public int EmpId;
        public string FirstName;
        public string LastName;

        public void EmpDetalis()
        {
            Console.WriteLine($"emplyee ID is {EmpId}");
            Console.WriteLine($"emplyee first name is {FirstName}");
            Console.WriteLine($"emplyee last name is {LastName}");
        }
        public static Employee GetTest()
        {
            return new Employee();
        }
    }

    //Events in Structure
    // A struct can contain events to notify subscribers about some action.

    //This structure contains CoordinatesChanged event,
    //which will be raised when x or y or z coordinate changes.
    
    struct worker
    {
        private int empid;
        private string firstname, lastname;

        public int x
        {
            get { return empid; }
            set { empid = value;
                workerInt(empid);
            }
        }
        public string y
        {
            get { return firstname; }
            set
            {
                firstname = value;
                workerString(firstname);
            }
        }
        public string z
        {
            get { return lastname; }
            set
            {
                lastname = value;
                workerString(lastname);
            }
        }
        public event Action<int> workerInt; // int event 
        public event Action<string> workerString; // string event
    }
}

namespace School
{

    struct student
    {

    }
    struct course
    {

    }
}
//A namespace can contain other namespaces.Inner namespaces can be separated using (.).

namespace School.Education
{
    struct StudentsList
    {

    }
}

//struct is a value type, so it is faster than a class object.
//Use struct whenever you want to just store the data. Generally,
//structs are good for game programming. However, it is easier to transfer a class object than a struct.
//So do not use struct when you are passing data across the wire or to other classes.


//1-struct can include constructors, constants, fields, methods, properties, indexers, operators, events & nested types.
//2-struct cannot include a parameterless constructor or a destructor.
//3-struct can implement interfaces, same as class.
//4-struct cannot inherit another structure or class, and it cannot be the base of a class.
//5-struct members cannot be specified as abstract, sealed, virtual, or protected.