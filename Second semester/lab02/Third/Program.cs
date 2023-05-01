using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read data from a CSV file
            string filePath = "products.csv";
            var lines = File.ReadAllLines(filePath);

            // Create a list of products
            var products = lines
                .Select(line => new Product
                {
                    Name = line.Split(',')[0],
                    Category = line.Split(',')[1],
                    Price = decimal.Parse(line.Split(',')[2])
                })
                .ToList();

            // Group products by their categories
            var productsByCategory = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    Count = g.Count(),
                    TotalPrice = g.Sum(p => p.Price)
                })
                .OrderByDescending(g => g.TotalPrice);

            // Display grouped data
            foreach (var group in productsByCategory)
            {
                Console.WriteLine($"{group.Category}: {group.Count} products, total price {group.TotalPrice}");
            }
        }
    }
}