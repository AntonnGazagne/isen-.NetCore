using System;
using isen.DotNet.Library;
using isen.DotNet.Library.Lists;

namespace isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyCollection<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            var enumerator = list.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
