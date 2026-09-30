namespace Asynkron01_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Øvelse 3.1
            /*
            int højde, bredde, areal;

            Console.WriteLine("Brug dette progtam til at udregne arelet af en rektangel.");
            Console.Write("Indtast højden på rektanglen: ");
            string brugerInput = Console.ReadLine() ?? "0";
            højde = int.Parse(brugerInput);

            Console.Write("Indtast bredde på rektanglen: ");
            brugerInput = Console.ReadLine();
            bredde = int.Parse(brugerInput);

            areal = højde * bredde;

            Console.WriteLine($"Arealet på rektanglen er: {areal}");
            Console.ReadLine();
            */

            // Øvelse 3.2/3
            double x1, x2, y1, y2, hældning;

            Console.WriteLine("Beregn hældning af linjestykke, med start i (x1, y1) og slutpunkt i (x2, y2)");
            Console.Write("Indtast x1: ");
            string input = Console.ReadLine();
            x1 = double.Parse(input);

            Console.Write("Indtast y1: ");
            input = Console.ReadLine();
            y1 = double.Parse(input);

            Console.Write("Indtast x2: ");
            input = Console.ReadLine();
            x2 = double.Parse(input);

            Console.Write("Indtast y2: ");
            input = Console.ReadLine();
            y2 = double.Parse(input);

            hældning = (y2 - y1) / (x2 - x1);

            Console.WriteLine($"Hældningen er: {hældning}");
            Console.ReadLine();

        }
    }
}
