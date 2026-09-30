namespace Pr06_UnitTestAndArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Øvelse 4.1A
            int andersAge = 35, kirushanAge = 23, majedAge = 24, baileyAge = 24, alexanderAge = 27, jakobAge = 21;

            Console.WriteLine("Der er følgende aldre ved mit bord:");
            Console.WriteLine(kirushanAge);
            Console.WriteLine(majedAge);
            Console.WriteLine(baileyAge);
            Console.WriteLine(alexanderAge);
            Console.WriteLine(jakobAge);
            Console.WriteLine(andersAge);

            double avgAge = (andersAge + kirushanAge + majedAge + baileyAge + alexanderAge + jakobAge) / 6.0;

            Console.WriteLine($"Gennemsnitlig alder: {avgAge:F2}");

            // Øvelse 4.2A
            int[] ages = { 35, 23, 24, 24, 27, 21 };
            int agesSum = 0;

            Console.WriteLine("Der er følgende aldre ved mit bord:");
            foreach (int age in ages)
            {
                Console.WriteLine(age);
                agesSum += age;
            }

            double ageAvg = (double)agesSum / ages.Length;

            Console.WriteLine($"Gennemsnitlig alder: {ageAvg:F2}");

            // Fra tidligere opgave (Pr05):
            /*
            Calculator calc = new();
            char operator_1;

            Console.WriteLine("Give me a number, followed by operator (+, -, *, /), followed by another number:");
            int num_1 = GetUserInt();

            do
            {
                operator_1 = GetUserChar("Enter a single operator (+, -, * or /:)");
            } while (!(operator_1 is '+' or '-' or '/' or '*'));

            int num_2 = GetUserInt();

            switch (operator_1)
            {
                case '+':
                    Console.WriteLine($"Result: " + calc.Add(num_1, num_2));
                    break;
                case '-':
                    Console.WriteLine($"Result: " + calc.Subtract(num_1, num_2));
                    break;
                case '*':
                    Console.WriteLine($"Result: " + calc.Multiply(num_1, num_2));
                    break;
                case '/':
                    Console.WriteLine($"Result: " + calc.Divide(num_1, num_2));
                    break;
            }
            */
        }

        public static int GetUserInt(string message = "Enter a whole number:")
        {
            int userInt;

            Console.WriteLine(message);
            string userInput = Console.ReadLine() ?? string.Empty;

            while (!int.TryParse(userInput, out userInt))
            {
                Console.WriteLine("Invalid input, please try again:");
                userInput = Console.ReadLine() ?? string.Empty;
            }

            return userInt;
        }

        public static char GetUserChar(string message = "Enter a single character:")
        {
            char userChar;

            Console.WriteLine(message);
            string userInput = Console.ReadLine() ?? string.Empty;

            while (!char.TryParse(userInput, out userChar))
            {
                Console.WriteLine("Invalid input, please try again:");
                userInput = Console.ReadLine() ?? string.Empty;
            }

            return userChar;
        }
    }
}
