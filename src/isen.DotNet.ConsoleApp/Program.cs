using System;
using isen.DotNet.Library;

namespace isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hello = new Hello("Antonn");
            var message = Hello.Greet();
            Console.WriteLine(message);
        }
    }
}
