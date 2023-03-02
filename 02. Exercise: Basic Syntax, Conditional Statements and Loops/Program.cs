namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            int freeBeltCount = 0;

            if (studentsCount >= 6)
            {
                for (int i = 6; i <= studentsCount; i += 6)
                {
                    freeBeltCount++;
                }
            }

            double A = studentsCount - freeBeltCount;
            double B = lightsabersPrice * Math.Ceiling(studentsCount + (studentsCount * 0.1));
            double fullPrice = B + (priceOfRobe * studentsCount) + priceOfBelt * A;

            if (amountOfMoney >= fullPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {fullPrice:F2}lv.");
            }
            else
            {
                double need = fullPrice - amountOfMoney;
                Console.WriteLine($"John will need {need:F2}lv more.");
            }
        }
    }
}