using System;

//1-The default access level for all interface members is public.
//2-An interface member whose declaration includes a body is a virtual member unless the sealed or private modifier is used.
//3-A private or sealed function member of an interface must have implementation body.
//4-Interfaces may declare static members which can be accessed by interface name.


//point to remmeber
//1-Interface cannot include private, protected, or internal members.All the members are public by default.
//2-Interface cannot contain fields, and auto-implemented properties.
//3-A class or a struct can implement one or more interfaces implicitly or explicitly.
//Use public modifier when implementing interface implicitly, whereas don't use it in case of explicit implementation.
//4-Implement interface explicitly using InterfaceName.MemberName.
//5-An interface can inherit one or more interfaces.



/*
namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //an interface can be defined using the interface keyword.
            //An interface can contain declarations of methods, properties, indexers, and events.
            //However, it cannot contain instance fields.

            //An interface cannot contain constructors and fields.
            //Interface members are by default abstract and public.

            // A class or a Struct can implement one or more interfaces using colon :.
            //On impmenting an interface, you must override all the members of an interface.


            // create an object of the class and assign it to a variable of an interface type
            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();
            //IFile file2 = new FileInfo();

            Console.WriteLine("=======Implicitly Implementation======");
            //Implicitly Implementation
            file1.ReadFile(); 
            file1.WriteFile("content");
            file1.Search("test");
            file2.ReadFile(); 
            file2.WriteFile("content");
            file2.Search("text");
        }
    }
    //The IFile interface contains two methods, ReadFile() and WriteFile(string).
    interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
        void Search(string text);
    }
    //the following FileInfo class implements the IFile interface, so it should override all the members of IFile.
    //Interface members must be implemented with the public modifier; otherwise, the compiler will give compile-time errors.
    class FileInfo : IFile
    {
        //Implicitly Implementation
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }
        public void WriteFile(string text)
        {
            Console.WriteLine("Writing to file");
        }
        public void Search(string text)
        {
            Console.WriteLine("Searching in file");
        }     
    }
}

*/
//=====================================================================================================================
/*
namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Explicit Implementation======");
            //Explicit Implementation
            IFile file3 = new FileInfo();
            FileInfo file4 = new FileInfo();

            file3.ReadFile();
            file3.WriteFile("content");
            //file3.Search("text to be searched");//compile-time error 

            file4.Search("text to be searched");
            //file4.ReadFile(); //compile-time error 
            //file4.WriteFile("content"); //compile-time error 
        }
    }
  
    interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }
    class FileInfo : IFile
    {
        // Explicit Implementation
        void IFile.ReadFile()
        {
            Console.WriteLine("Reading from file");
        }
        void IFile.WriteFile(string text)
        {
            Console.WriteLine("Writing to a file");
        }

        public void Search(string text)
        {
            Console.WriteLine("Search in a file");
        }
    }
}
*/
//============================================================================================================
/*
namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Implementing Multiple Interfaces======");

            //A class or struct can implement multiple interfaces. 
            //It must provide the implementation of all the members of all interfaces.

            IFile file1 = new FileInfo();
            IBinaryFile file2 = new FileInfo();
            FileInfo file3 = new FileInfo();

            file1.ReadFile();

            file2.OpenBinaryFile();
            file2.ReadFile();
           
            file3.Search("test");
        }
    }
    interface IFile
    {
        void ReadFile();
    }
    interface IBinaryFile
    {
        void OpenBinaryFile();
        void ReadFile();
    }
    class FileInfo : IFile , IBinaryFile
    {
        void IFile.ReadFile()
        {
            Console.WriteLine("Reading File");
        }
        void IBinaryFile.OpenBinaryFile()
        {
            Console.WriteLine("Opening a file");
        }
        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Reading File");
        }
        public void Search(string text)
        {
            Console.WriteLine("Seacchign in a file");
        }

        //Above, the FileInfo implements two interfaces IFile and IBinaryFile explicitly.
        //It is recommended to implement interfaces explicitly when implementing multiple interfaces
        //to avoid confusion and more readability.
    }
}
*/
//=====================================================================================================================
namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

           //Till now, we learned that interface can contain method declarations only.
           //C# 8.0 added support for virtual extension methods in interface with concrete implementations.
           // The virtual interface methods are also called default interface methods that
           //do not need to be implemented in a class or struct.

            Console.WriteLine("=======Default Interface Methods======");
            IFile file1 = new FileInfo();

            file1.ReadFile();
            file1.WriteFile("content");
            file1.Search();

            FileInfo file2 = new FileInfo();
            file2.ReadFile();
           // file2.Search();//compile time error
        }
    }
   // methods that do not need to be implemented in a class or struct.
    interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
        void Search()
        {
            Console.WriteLine("searching in a file");
        }
    }
    class FileInfo : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }
        public void WriteFile(string text)
        {
            Console.WriteLine("Writing to file");
        }
        //does not need to be implmented
        //public void Search()
        //{
        //    Console.WriteLine("Searching in file");
        //}
    }
}