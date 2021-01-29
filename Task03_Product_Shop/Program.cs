using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03_Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> productInfo = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] comand = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (comand[0].ToUpper() == "REVISION")
                {
                    break;
                }

                string shop = comand[0];
                string product = comand[1];
                double price = double.Parse(comand[2]);

                if(!productInfo.ContainsKey(shop))
                {
                    productInfo[shop] = new Dictionary<string, double>();
                }
                if(!productInfo[shop].ContainsKey(product))
                {
                    productInfo[shop].Add(product, price);
                }
                else
                {
                    productInfo[shop][product] = price;
                }
                
                
            }

            foreach (var element in productInfo)
            {
                Console.WriteLine($"{element.Key}->");
                foreach (var info in element.Value)
                {
                    Console.WriteLine($"Product: {info.Key}, Price: {info.Value}");
                }
            }
            
            //Console.WriteLine("Hello World!");
        }
    }
}
