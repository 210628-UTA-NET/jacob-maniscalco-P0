using System;

namespace StoreModels
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer me = new Customer();

            me.address = "test";

            Console.WriteLine(me.address);
            Console.WriteLine("Hello World!");
        }
    }
}
