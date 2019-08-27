using System;

namespace generic_class1
{
    interface IData<T>
    {
        // in interface we dont need to declare interface and methods and variables of interface
        // public, by default interface and its methods and variables are public, so
        //no need to declare public separately otherwise it will give error.
        //* everything in interface is public and abstract.
       
       //**************************************************/
        
        // by using generic interfaces you can use same generic functions with different data
       //types in different classes.
       // e.g one function can be implemented for int and string both types, and you dont need 
       // separate functions for separate type implementation each time .

     // generics is usefull if want to reuse one class,interfaceor method with different types.
    //Generics are code templates that allow developers to create type-safe code without referring to specific data types.
    //In simple terms, Generics are classes, structures, interfaces and methods that have placeholders 
    //for one or more of the types they store or use.
    
        void data_fun(T data, T val);
    }

    public class in_data : IData<int>
    {

        int res;

        public void data_fun(int data, int val)
        {
            Console.WriteLine("Enter number 1:");
            string val1 = Console.ReadLine();
            data = Convert.ToInt32(val1);

            Console.WriteLine("Enter number 2:");
            string val2 = Console.ReadLine();
            val = Convert.ToInt32(val2);

            // data = 2;
            // val = 8;
            res = data * val;
            Console.WriteLine("Result for int data : "  + res);
        }


    }

    public class in_string : IData<string>
    {
        string result;
        public void data_fun(string data, string val)
        {

            Console.WriteLine("Enter string 1:");
             data = Console.ReadLine();
            //  data = Convert.ToInt32(val);

            Console.WriteLine("Enter string 2:");
            val = Console.ReadLine();
            // val = Convert.ToInt32(val);

            //  data = "concatenate";
            // val = "Data";
            result = String.Concat(data, val);

            Console.WriteLine("Result for string data : " + result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Hello World!");

            IData<int> id;
            in_data idat = new in_data();
            id = idat;
            
            id.data_fun(0,0);

            IData<string> sd;
            in_string isit = new in_string();
            sd = isit;
            sd.data_fun("", "");

            Console.WriteLine("************************************");

           // Console.ReadKey();
        }
    }
}
