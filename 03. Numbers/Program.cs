using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ")
                                              .Select(int.Parse)
                                              .ToArray();


            List<decimal> numberOutput = new List<decimal>();
            List<decimal> topFiveNumbers = new List<decimal>();

            decimal sum = numbers.Sum();

            decimal totalSum = sum / numbers.Length;

            for (int i = 0; i < numbers.Length; i++)
            {
                decimal currentNumber = numbers[i];

                if (totalSum < currentNumber)
                {
                    numberOutput.Add(currentNumber);
                }

            }
            numberOutput.Sort();

            int topFive = 0;

            for (int i = numberOutput.Count - 1; i >= 0; i--)
            {

                if (5 == topFive)
                {
                    break;
                }
                topFiveNumbers.Add(numberOutput[i]);
                topFive++;
            }
            if (topFiveNumbers.Count == 0 || numbers.Length < 5)
            {
                Console.WriteLine("No");
                Environment.Exit(0);
            }

            Console.WriteLine(string.Join(" ", topFiveNumbers));
        }
    }
}
