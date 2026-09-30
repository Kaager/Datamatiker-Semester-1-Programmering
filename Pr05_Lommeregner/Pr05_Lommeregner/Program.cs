namespace Pr05_Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new();
            char operator_1;

            Console.WriteLine("Give me a number, followed by operator (+, -, *, /), followed by another number:");
            int num_1 = GetUserInt();

            do
            {
                operator_1 = GetUserChar("Enter a single operator (+, -, * or /:)");
            } while (!(operator_1 is '+' or '-' or '/' or '*' ));

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
