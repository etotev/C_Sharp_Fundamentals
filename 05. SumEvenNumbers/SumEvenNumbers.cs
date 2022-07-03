using System;
using System.Linq;

namespace _05._SumEvenNumbers
{
    internal class SumEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countOfNumbers = numbers.Length - 1;
            int result = 0;
            
            for (int i = 0; i <= countOfNumbers; i ++)
            {
                if(numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                }
            }

            Console.WriteLine(result);
         }
    }
}
