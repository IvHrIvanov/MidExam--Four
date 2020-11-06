using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string[] comand = Console.ReadLine().Split(" ");

            while (comand[0] != "end")
            {
                if (comand[0] == "swap" || comand[0] == "multiply")
                {

                    int indexOne = int.Parse(comand[1]);
                    int indexTwo = int.Parse(comand[2]);

                    int firstNumber = array[indexOne];
                    int secondNumber = array[indexTwo];

                    if (comand[0] == "swap")
                    {

                        array[indexOne] = secondNumber;
                        array[indexTwo] = firstNumber;

                    }
                    else if (comand[0] == "multiply")
                    {

                        array[indexOne] = array[indexOne] * array[indexTwo];

                    }
                }
                else if (comand[0] == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] -= 1;
                    }
                }

                comand = Console.ReadLine().Split(" ");
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
