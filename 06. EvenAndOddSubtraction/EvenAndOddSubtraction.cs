using System;
using System.Linq;

namespace _06._EvenAndOddSubtraction
{
    internal class EvenAndOddSubtraction
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countOfNunmbers = numbers.Length - 1;
            int sumOfOdds = 0;
            int sumOfEvens = 0;

            for (int i = 0; i <= countOfNunmbers; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    sumOfEvens += numbers[i];
                } else
                {
                    sumOfOdds += numbers[i];
                }
            }

            int result = sumOfEvens - sumOfOdds;
          
            Console.WriteLine(result);
        }
    }
}
