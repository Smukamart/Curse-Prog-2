using System;
using Course1.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Course1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of Products: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} Data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());
                if (c == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                }
                else if (c == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if(c == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Customs Free: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product obj in products)
            {
                Console.WriteLine(obj.priceTag());
            }
        }
    }
}
