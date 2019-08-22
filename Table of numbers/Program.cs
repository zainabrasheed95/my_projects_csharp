using System;

namespace test_prog3._2
{
    class Program
    {
           public static int n;

        public static void table()
        {
                // int num;

            Console.WriteLine("Enter any number ");
            Console.WriteLine("*********************");
               
            string val=Console.ReadLine();
            //  bool convert = Int32.TryParse(val, out num);

          //  bool n=Int32.TryParse(val,out num);
               n = Convert.ToInt32(val);
                        
                        Console.Write("\n");
                     Console.WriteLine("*********************");
                     Console.WriteLine("Table of " + n +" " + "is :");
                     Console.WriteLine("*********************");

            for(int i=1; i<=10; i++)
            {
                   int num_tab=n*i;

                    
                   Console.WriteLine(n+" " + "*"+ " " + i +" "+ "=" +" "+ num_tab);

                   Console.Write("\n");

            }
                 

        }

        static void Main(string[] args)
        {
            
              table();

              
        }
    }
}
