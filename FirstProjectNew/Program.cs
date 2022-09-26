using System;

namespace FirstProjectNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SayHello("MITKO Svetlyo"));
        }

        private static string SayHello(string name)
        {
            return $"Hello my name is {name}";
        }
    }
}
