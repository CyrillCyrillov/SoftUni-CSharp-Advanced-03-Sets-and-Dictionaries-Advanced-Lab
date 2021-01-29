using System;
using System.Collections.Generic;

namespace Task05_Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int numbers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbers; i++)
            {
                names.Add(Console.ReadLine());
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
