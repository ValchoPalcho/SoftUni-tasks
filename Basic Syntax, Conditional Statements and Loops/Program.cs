namespace _9._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;

            for (int i = 1; i <= i; i += 2)
            {
                if (count == numberOfNumbers)
                {
                    Console.WriteLine($"Sum: {sum}");
                    break;
                }
                Console.WriteLine(i);
                sum += i;
                count++;
            }
        }
    }
}