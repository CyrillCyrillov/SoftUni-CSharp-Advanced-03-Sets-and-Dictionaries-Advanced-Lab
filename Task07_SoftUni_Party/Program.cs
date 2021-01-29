using System;
using System.Collections.Generic;
using System.Linq;

namespace Task07_SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> ordinary = new HashSet<string>();

            while (true)
            {
                string invitedName = Console.ReadLine();
                if(invitedName == "PARTY")
                {
                    break;
                }

                string firstSymbol = invitedName[0].ToString();
                if (int.TryParse(firstSymbol, out int result))
                {
                    vip.Add(invitedName);
                }
                else
                {
                    ordinary.Add(invitedName);
                }
            }

            while (true)
            {
                string comeName = Console.ReadLine();
                if(comeName == "END")
                {
                    break;
                }

                vip.Remove(comeName);
                ordinary.Remove(comeName);
            }

            Console.WriteLine(vip.Count + ordinary.Count);

            foreach (string name in vip)
            {
                Console.WriteLine(name);
            }

            foreach (string name in ordinary)
            {
                Console.WriteLine(name);
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
