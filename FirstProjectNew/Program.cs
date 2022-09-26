using System;

namespace FirstProjectNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SayHello("Plamen2"));
        }

        private static string SayHello(string name)
        {
            return $"Hello my name is {name}";
        }
    }
}
