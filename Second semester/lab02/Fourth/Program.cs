using System;
using System.Collections.Generic;

namespace Fourth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() { "one", "two", "three", "four", "five" };

            Func<string, int> stringLengthDelegate = s => s.Length;

            foreach (var str in strings)
            {
                int length = stringLengthDelegate(str);
                Console.WriteLine($"{str}: {length}");
            }
        }
    }
}