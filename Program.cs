using System;

namespace hello_console
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = SayHello("world");

            Console.WriteLine(name);
        }

        static string SayHello(string name)
        {
            return "Hello " + name + "!";
        }
    }
}
