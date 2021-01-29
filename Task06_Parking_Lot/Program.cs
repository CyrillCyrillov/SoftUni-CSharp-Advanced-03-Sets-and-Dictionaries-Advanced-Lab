using System;
using System.Collections.Generic;
using System.Linq;

namespace Task06_Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carsInParking = new HashSet<string>();

            while (true)
            {
                string[] comand = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if(comand[0] == "END")
                {
                    break;
                }

                if(comand[0] == "IN")
                {
                    carsInParking.Add(comand[1]);
                }
                else if(comand[0] == "OUT")
                {
                    carsInParking.Remove(comand[1]);
                }
            }
            

            if(carsInParking.Count > 0)
            {
                foreach (string carRegistration in carsInParking)
                {
                    Console.WriteLine(carRegistration);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
