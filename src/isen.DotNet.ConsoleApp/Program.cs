using System;
using isen.DotNet.Library;
using isen.DotNet.Library.Lists;

namespace isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyCollection();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            foreach (var v in list.Values)
            {
                Console.WriteLine(v);
            }
        }
    }
}
