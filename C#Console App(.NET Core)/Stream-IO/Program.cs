using System;
using System.IO;
using System.Text;

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
            //Create object of FileInfo for specified path            
            FileInfo fi = new FileInfo(@"Descktop:\DummyFile.txt");

            //Open file for Read\Write
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            //create byte array of same size as FileStream length
            byte[] fileBytes = new byte[fs.Length];

            //define counter to check how much bytes to read. Decrease the counter as you read each byte
            int numBytesToRead = (int)fileBytes.Length;

            //Counter to indicate number of bytes already read
            int numBytesRead = 0;

            //iterate till all the bytes read from FileStream
            while (numBytesToRead > 0)
            {
                int n = fs.Read(fileBytes, numBytesRead, numBytesToRead);

                if (n == 0)
                    break;

                numBytesRead += n;
                numBytesToRead -= n;
            }

            //Once you read all the bytes from FileStream, you can convert it into string using UTF8 encoding
            string filestring = Encoding.UTF8.GetString(fileBytes);
        }
    }
}


//Files & Directories
//They can be used to access directories, access files, open files for reading or writing,
//create a new file or move existing files from one location to another.


//FileInfo
//The FileInfo class provides the same functionality as the static File class but you have
//more control on read/write operations on files by writing code manually for reading or writing bytes from a file.