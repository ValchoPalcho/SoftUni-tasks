using System;

namespace C_sharp_traingng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            bool isSpecialNumber = true;

            for (int i = 1; i <= numberCount; i++)
            {
                int currentNumber = i;

                int sum = 0;

                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> {1}", i, isSpecialNumber);
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", i, !isSpecialNumber);
                }
            }
        }
    }
}