namespace _05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int letters = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < letters; i++)
            {
                string input = Console.ReadLine();
                int digitLength = input.Length;
                int digit = input[0] - '0';
                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    message += (char)(digit + 32);
                    continue;
                }

                if (digit == 8 || digit == 9)
                {
                    offset++;
                }
                int letterIndex = offset + digitLength - 1;
                message += (char)(letterIndex + 97);
            }
            Console.WriteLine(message);
        }
    }
}