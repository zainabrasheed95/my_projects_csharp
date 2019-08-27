using System;

namespace generic_fun
{
    class generic_use
    {
       public void data<T_data>(int i, string msg , T_data val)
       {
           
               Console.WriteLine(i + " : " + "Student Data Is : " + msg + val);
           
       }

    }

    class Program
    {
        static void Main(string[] args)
        {
            generic_use gu = new generic_use();

            Console.WriteLine("Hello User !");
              
              gu.data<string>( 1 ,"Name of student : " , "Zoya");
              gu.data<int>(2 , "Age of student : " , 20);
              gu.data<Double>( 3, "CGPA of student : " , 3.8);

        }
    }
}
