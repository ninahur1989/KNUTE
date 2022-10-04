using System;
using System.Reflection;

namespace hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (true)
            {
                Console.WriteLine(  );
            } 
            else if(false)
            {
                Console.WriteLine();
            }


            Address address1 = new Address();
            Address address = new Address();
            address.Apartment = "ds";
            address.Street = "ds";
            address.House = "ds";
            address.City = "ds";
            address.Index = 1;
            Console.WriteLine(address1.ToString());
            Console.ReadLine();

            //foreach (PropertyInfo property in address.GetType().GetProperties())
            //{
            //    Console.WriteLine(property.Name + " : " + property.GetValue(address, null));
            //}

            foreach (PropertyInfo property in address1.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(address1, null));
            }

            foreach (PropertyInfo property in address.GetType().GetProperties())
            {
                property.SetValue(address1, property.GetValue(address), null);
            }

            foreach (PropertyInfo property in address1.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(address1, null));
            }

            Console.ReadLine();




        }
    }
}
