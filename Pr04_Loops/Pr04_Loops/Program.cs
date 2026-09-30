namespace Pr04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prac2_8();
            //Prac2_9();
            //Prac2_10();
            //Prac2_11();
            Prac2_12();
        }

        static void Prac2_8()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Heltals division med remainder");
                Console.WriteLine("0. Exit");

                int menuChoice = int.Parse(Console.ReadLine());

                if (menuChoice == 1)
                {
                    Console.Clear();
                    Console.Write("Indtast et heltal: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Indtast et andet heltal: ");
                    int b = int.Parse(Console.ReadLine());

                    int wholeNumberDivision = a / b;
                    int remainder = a % b;

                    Console.WriteLine($"Heltalskvotienten er {wholeNumberDivision} og rest-delen er {remainder}.");
                    Console.ReadKey();
                }
                else if (menuChoice == 0)
                {
                    Environment.Exit(0);
                }
            }
        }

        static void Prac2_9()
        {
            Console.WriteLine("Skriv en sætning, og du vil få hver anden karakter udskrevet (start er anden karakter):");
            string inputString = Console.ReadLine();

            for (int i = 0; i < inputString.Length; i++)
            {
               if (i % 2 == 1) // index starts a 0, so to get every other char, starting from the second, we need to print odd numbers
                {
                    Console.Write(inputString[i]);
                }
            }
        }

        static void Prac2_10()
        {
            Console.WriteLine("Indtast noget information, og programmet vil finde alle cifre (0-9) sammen med det index de blev fundet på:");
            string inputString = Console.ReadLine();

            for (int i = 0; i < inputString.Length; i++)
            {
                char x = inputString[i];
                if (char.IsNumber(x))
                {
                    Console.WriteLine($"Index {i} : {x} (ciffer)");
                }

            }
        }

        static void Prac2_11()
        {
            Console.WriteLine("Indtast noget information, få \"Index : karakter (ciffer/operatør/ukendt)\"");
            string inputString = Console.ReadLine();

            for (int i = 0; i < inputString.Length; i++)
            {
                char x = inputString[i];
                if (char.IsNumber(x))
                {
                    Console.WriteLine($"Index {i,3} : {x} (ciffer)");
                }
                else if (x == '+' || x == '-')
                {
                    Console.WriteLine($"Index {i,3} : {x} (operator)");
                }
                else
                {
                    Console.WriteLine($"Index {i,3} : {x} (ukendt)");
                }
            }
        }

        static void Prac2_12()
        {
            Console.WriteLine("Indtast et simpelt regne stykke (+/-) med cif (eks: 1+2+3-2:");
            string inputString = Console.ReadLine();
            int result = int.Parse(inputString[0].ToString());
            
            for (int i = 1; i < inputString.Length; i++)
            {
                if (!char.IsNumber(inputString[i]))
                {
                    if (inputString[i] == '+')
                        result += int.Parse(inputString[i + 1].ToString());
                    else if (inputString[i] == '-')
                        result -= int.Parse(inputString[i + 1].ToString());
                }
            }
            Console.WriteLine(result);
        }
    }
}
