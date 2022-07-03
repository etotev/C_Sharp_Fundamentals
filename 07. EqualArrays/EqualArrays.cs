using System;
using System.Linq;

namespace _07._EqualArrays
{
    internal class EqualArrays
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int countOfArray = firstArray.Length;

            int firstDifferentIndex = 0;
            int sum = 0;

            for (int i = 0; i < countOfArray; i++)
            {
                if (secondArray[i] != firstArray[i])
                {
                    firstDifferentIndex = i;
                    Console.WriteLine($"Arrays are not identical. Found difference at {firstDifferentIndex} index");
                    return;
                }
                sum += firstArray[i];
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");

        }
    }
}