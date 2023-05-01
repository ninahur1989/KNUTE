using System;

namespace Second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose categoty:");

            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine($"{category} - {(int)category}");
            }

            Category filterCategory = (Category)int.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter max price:");
            double filterPrice = double.Parse(Console.ReadLine());

            Predicate<Product> filter = p => p.Category == filterCategory && p.Price > filterPrice;

            Action<Product> display = p => Console.WriteLine($"{p.Name} - {p.Price}");

            for (int i = 1; i <= 3; i++)
            {
                string fileName = $"{i}.json";

                using (StreamReader reader = new StreamReader(fileName))
                {
                    string json = reader.ReadToEnd();
                    List<Product> products = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(json);

                    foreach (Product p in products)
                    {
                        if (filter(p))
                        {
                            display(p);
                        }
                    }
                }
            }
        }
    }
}