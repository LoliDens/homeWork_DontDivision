using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_DontDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int lowerLimitRandom = 1;
            int upperLimitRandom = 27;
            int number = random.Next(lowerLimitRandom, upperLimitRandom + 1);
            int upperLimitCycle = 999;
            int lowerLimitCycle = 100;
            int amountMultiples = 0;
            
            for (int i = 0; i <= upperLimitCycle; i += number) 
            {
                if (i >= lowerLimitCycle) 
                {
                    amountMultiples++;
                }
            }

            Console.WriteLine($"Количество трехзначных натуральных чисел, которые кратны {number}: {amountMultiples}");
            Console.ReadKey();
        }
    }
}
