using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace test_prog3._1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> list_number=new List<int>();
            for(int i=1; i<=10 ;i++)
            {
            list_number.Add(i);
            }
            foreach (var item in list_number)
            {
                Console.WriteLine("list : " + item);
                
            }
               int min=1;
               int max=40;
               int ran_num;

               Random ran=new Random();
               
                   for(int j=1; j<=5; j++)
               {

                 do
                 {
                     
               
                ran_num=ran.Next(min,max);
               
                 }
                 while(list_number.Contains(ran_num));
             
               list_number.Add(ran_num);
               
                
               Console.WriteLine("random numbers are : " + ran_num);
               }
               
               
               foreach(var ran_item in list_number)
               {
                   Console.WriteLine("list of all numbers :" + ran_item);
               }
        }
    }
}
