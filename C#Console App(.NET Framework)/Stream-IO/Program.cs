using System;

//FileStream reads or writes bytes from/to a physical file, whether it is a .txt, .exe, .jpg, or any other file.
//FileStream is derived from the Stream class.

//MemoryStream: MemoryStream reads or writes bytes that are stored in memory.

//BufferedStream: BufferedStream reads or writes bytes from other Streams to improve certain I/O operations' performance.

//NetworkStream: NetworkStream reads or writes bytes from a network socket.

//PipeStream: PipeStream reads or writes bytes from different processes.

//CryptoStream: CryptoStream is for linking data streams to cryptographic transformations.



//StreamReader : converting bytes into characters

//StreamWriter : converting characters into bytes

//BinaryReader : BinaryReader is a helper class for reading primitive datatype from bytes.

//BinaryWriter : BinaryWriter writes primitive types in binary.


//Stream is an abstract class for transfering bytes from different sources.
//It is base class for all other class that reads\writes bytes to different sources.


namespace Stream_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
