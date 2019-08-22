using System;
using System.IO;

namespace test_prog3
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
String line;
try
{
   //Pass the file path and file name to the StreamReader constructor
 string path = @"C:\Users\haier\Desktop\random_file.txt";
// string path = @"C:\Users\haier\Desktop\CS Code (Commands).txt";

using(StreamReader sr = new StreamReader(path))
{
//Read the first line of text
line = sr.ReadLine();

//Continue to read until you reach end of file
while (line != null) 
{
//write the lie to console window
Console.WriteLine(line);
//Read the next line
line = sr.ReadLine();
}

//close the file
sr.Close();
Console.ReadLine(); 
}
}
catch (System.Exception)
{
    
    throw;
}

}




        }
    
    
    
}
