using System;
using System.Collections.Generic;
using System.Linq;

namespace Task04_Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var geographic = new Dictionary<string, Dictionary<string, List<string>>>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                string[] nextLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string continent = nextLine[0];
                string country = nextLine[1];
                string city = nextLine[2];

                if(!geographic.ContainsKey(continent))
                {
                    geographic[continent] = new Dictionary<string, List<string>>();
                }
                if(!geographic[continent].ContainsKey(country))
                {
                    geographic[continent][country] = new List<string>();
                }

                //if(!geographic[continent][country].Contains(city))
                //{
                    geographic[continent][country].Add(city);
                //}
            }

            foreach (var continent in geographic)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.Write($"  {country.Key} -> ");
                    //foreach (var city in country.Value)
                    //{
                    //Console.WriteLine(string.Join(", ", city));
                    //}

                    for (int i = 0; i <= country.Value.Count - 1; i++)
                    {
                        Console.Write(country.Value[i]);
                        if(i != country.Value.Count - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            
            
            //Console.WriteLine("Hello World!");
        }
    }
}
