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
            int upperLimitRandom = 28;
            int number = random.Next(lowerLimitRandom, upperLimitRandom);
            int upperLimitCycle = 999;
            int lowerLimitCycle = 100;
            int amountMultiples = 0;
            int multiples;

            for (int i = lowerLimitCycle; i <= upperLimitCycle; i++) 
            {
                multiples = i;

                while (multiples > 0) 
                {
                    multiples -= number;
                }

                if (multiples == 0) 
                {
                    amountMultiples += 1;
                }            
            }

            Console.WriteLine($"Количество трехзначных натуральных чисел, которые кратны {number}: {amountMultiples}");
            Console.ReadKey();
        }
    }
}
