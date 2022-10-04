using System;

namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(36.65, 37.06 , 0.60);

            Console.WriteLine("write value of uah");
            converter.ConvertFromUah(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("write value any other currency");
            converter.ConvertToUah(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();

        }
    }
}
