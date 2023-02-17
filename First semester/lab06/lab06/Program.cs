using lab06.MyList;
using System;
using System.Collections.Generic;

namespace lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(MyClass<List<int>>.FactoryMethod());

        }
    }
}
