﻿namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsulesCount = int.Parse(Console.ReadLine());
            double formula = ((days * capsulesCount) * pricePerCapsule);
            double fullSum = 0;
            fullSum += formula;

            int count = 0;
            while (true)
            {
                count++;
                Console.WriteLine($"The price for the coffee is: ${formula:F2}");
                if (count == countOfOrders)
                {
                    Console.WriteLine($"Total: ${fullSum:F2}");
                    break;
                }

                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());
                formula = ((days * capsulesCount) * pricePerCapsule);
                fullSum += formula;
            }
        }
    }
}