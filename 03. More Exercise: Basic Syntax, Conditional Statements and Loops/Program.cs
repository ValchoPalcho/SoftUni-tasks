namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            int MID = 0;

            if (a > maxValue)
            {
                maxValue = a;
            }

            if (b > maxValue)
            {
                maxValue = b;
            }

            if (c > maxValue)
            {
                maxValue = c;
            }

            if (a < minValue)
            {
                minValue = a;
            }

            if (b < minValue)
            {
                minValue = b;
            }

            if (c < minValue)
            {
                minValue = c;
            }

            if (a != maxValue && a != minValue)
            {
                MID = a;
            }

            if (b != maxValue && b != minValue)
            {
                MID = b;
            }

            if (c != maxValue && c != minValue)
            {
                MID = c;
            }

            if (a == b && b == c && a == c)
            {
                MID = a;
                maxValue = b;
                minValue = c;
            }

            if (a == b && a > c)
            {
                minValue = c;
                MID = b;
                maxValue = a;
            }

            if (c == b && c > a)
            {
                minValue = a;
                MID = b;
                maxValue = c;
            }

            if (a == c && c > b)
            {
                minValue = b;
                MID = a;
                maxValue = c;
            }

            if (a == b && a < c)
            {
                maxValue = c;
                MID = a;
                minValue = b;
            }

            if (c == b && c < a)
            {
                maxValue = a;
                MID = c;
                minValue = b;
            }

            if (a == c && c < b)
            {
                maxValue = b;
                MID = a;
                minValue = c;
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(MID);
            Console.WriteLine(minValue);
        }
    }
}