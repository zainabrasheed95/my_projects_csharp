using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             Print<SomeSerializer>(new SomeSerializer());
            Print(new SomeSerializer());
            var intbox = new Box<int>(5);
            var doubleBox = new Box<double>(2.2);
        }



        public interface ISerializer
        {
            string SomeProperty { get; set; }
            string Serialize(Object o);
        }

        public class SomeSerializer : ISerializer
        {
            public string SomeProperty { get; set; }

            public string Serialize(object o)
            {
                return $"{nameof(SomeSerializer)}:{o.ToString()}";
            }
        }
        public static void Print<TObject>(TObject ob) where TObject: ISerializer
        {
            Console.WriteLine(ob.Serialize("print Tobject fun calling serialize object"));
        }

        public static void Print(SomeSerializer ob)
        {
            Console.WriteLine(ob.Serialize("print fun SomeSerializer"));
        }

        public static void Print(ISerializer serializer)
        {
            Console.WriteLine(serializer.Serialize("print fun Iserializer"));
        }
    }
}
