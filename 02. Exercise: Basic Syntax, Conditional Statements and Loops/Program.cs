namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetP = double.Parse(Console.ReadLine());
            double mouseP = double.Parse(Console.ReadLine());
            double keyboardP = double.Parse(Console.ReadLine());
            double displayP = double.Parse(Console.ReadLine());

            int headsetLoseCount = 0;
            for (int headset = 2; headset <= lostGamesCount; headset += 2)
            {
                headsetLoseCount++;
            }

            int mouseLoseCount = 0;
            for (int mouse = 3; mouse <= lostGamesCount; mouse += 3)
            {
                mouseLoseCount++;
            }

            int keyboardLoseCount = 0;
            for (int gameLoseTwin = 6; gameLoseTwin <= lostGamesCount; gameLoseTwin += 6)
            {
                keyboardLoseCount++;
            }

            int displayLoseCount = 0;
            for (int display = 0; display <= keyboardLoseCount; display += 2)
            {
                if (display == 0)
                {
                    displayLoseCount += display;
                }
                else
                {
                    displayLoseCount++;
                }
            }

            double all = (headsetP * headsetLoseCount) + (mouseP * mouseLoseCount) + (keyboardP * keyboardLoseCount) + (displayP * displayLoseCount);

            Console.WriteLine($"Rage expenses: {all:F2} lv.");
        }
    }
}