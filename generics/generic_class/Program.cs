using System;

namespace test_generics
{
      public class gen_test<T>
      {
    //by using generic class we dont have to specify data types for function or variable calls 
   // of different types we speify different types in objects of class.
   // we can call same variable with different data types in object of class.
   // so instead of creating seperate class for int and separate class for string we 
   // .. created one single generic class.

           public T data;
           public T value
           {
               get 
               {
                   return this.data;
               }

               set 
               {
                   this.data=value;
               }
           }

         
      }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
          
          gen_test<int> intdata=new gen_test<int>();
          intdata.value=66467;
          
            //int test ="";

          gen_test<string> stringdata = new gen_test<string>();
          stringdata.value="string data here";

          gen_test<double> doubledata = new gen_test<double>();
          doubledata.value = 655.2;

          
          Console.WriteLine("int data is :" + intdata.value);

          Console.WriteLine("string data is :" + stringdata.value);

           Console.WriteLine("double data is :" + doubledata.value);
            
          Console.WriteLine();

        }
    }
}
