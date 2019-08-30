using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace asynawait_readfile
{
    class Program
    {
       
            public static string path = @"C:\Users\haier\Desktop\VS Code (Commands).txt";

            public static void method1()
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("methd1 is calling");
                }

            }

            public static void method2()
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("methd2 is calling");
                }

            }

            static async void CallMethod()
            {

                Task<int> task = read_file(path);
                // int length = await task;

                method1();

                int length = await task;
                Console.WriteLine(" Total length: " + length);


                method2();

            }


            public static async Task<int> read_file(string file)
            {

                // string path = "c:\\VS Code (Commands).txt";
                int length = 0;



                Console.WriteLine("File reading has started ");
                using (StreamReader sr = new StreamReader(file))
                {


                    string line = await sr.ReadToEndAsync();
                    // string line = sr.ReadToEnd(); 

                    length = line.Length;
                }

                Console.WriteLine("File reading has completed ");

                return length;
            }

            static void Main(string[] args)
            {
                Task task = new Task(CallMethod);
                task.Start();
                task.Wait();

                Console.ReadLine();

                Console.ReadKey();
            }
        }
}
