using System;

namespace ConsoleApp1
{
    public class demo : Exception
    {
        public static void Initialize(int size) { }
        protected static readonly int _item;
        public static int item { get { return _item; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c = new Class1(1);

            Console.WriteLine("Hello World!");
        }
    }
}
