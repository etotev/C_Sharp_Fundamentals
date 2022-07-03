using System;

namespace _04.ReverseArrayOfStrings
{
    internal class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] stringsToReverse = Console.ReadLine().Split();
            int countOfStrings = stringsToReverse.Length - 1;

            for(int i = countOfStrings; i >= 0; i--)
            {
                Console.Write(stringsToReverse[i] + ' ');
            }
        }
    }
}
