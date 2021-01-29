using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02_Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for (int i = 1; i <= numbers; i++)
            {
                string[] nextLineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = nextLineInfo[0];
                decimal grade = decimal.Parse(nextLineInfo[1]);

                if(students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<decimal> { grade });
                }
            }

            foreach (var studentName in students)
            {
                Console.Write($"{studentName.Key} -> ");
                foreach (var grades in studentName.Value)
                {
                    Console.Write($"{grades:f2} ");
                }
                Console.WriteLine($"(avg: {studentName.Value.Average():f2})");
                
                

            }
        }
    }
}
