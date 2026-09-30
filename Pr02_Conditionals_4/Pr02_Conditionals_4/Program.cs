using System.ComponentModel.DataAnnotations;

namespace Pr02_Conditionals_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Den fantastiske menu:");
            Console.WriteLine();
            Console.WriteLine("1. Gør dit");
            Console.WriteLine("2. Gør dat");
            Console.WriteLine("3. Gør noget");
            Console.WriteLine("4. Få svaret på livet, universet og alting");
            Console.WriteLine();
            Console.WriteLine("Indtast menupunkt 1, 2, 3 eller 4: ");

            string choiceString = Console.ReadLine() ?? "0";
            int choiceInt = int.Parse(choiceString);
            string message;

            switch (choiceInt)
            {
                case 1:
                    message = "Punkt 1 er valgt: Gør dit";
                    break;
                case 2:
                    message = "Punkt 2 er valgt: Gør dat";
                    break;
                case 3:
                    message = "Punkt 3 er valgt: Gør noget";
                    break;
                case 4:
                    message = "Punkt 4 er valgt: 42";
                    break;
                default:
                    message = "Forkert valg";
                    break;
            }

            Console.WriteLine(message);
        }
    }
}
