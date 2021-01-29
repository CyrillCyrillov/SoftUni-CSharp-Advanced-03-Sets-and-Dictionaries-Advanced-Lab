using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Sets_and_Dictionaries_Advanced_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Dictionary<double, int> counters = new Dictionary<double, int>();

            foreach (double element in inputNumbers)
            {
                if (counters.ContainsKey(element))
                {
                    counters[element]++;
                }
                else
                {
                    counters.Add(element, 1);
                }
            }

            foreach (var element in counters)
            {
                Console.WriteLine($"{element.Key} - {element.Value} times");
            }
        }
    }
}
