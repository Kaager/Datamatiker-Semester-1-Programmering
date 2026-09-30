namespace Pr02_Conditionals_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast navn: ");
            string navn = Console.ReadLine();

            Console.Write("Indtast alder: ");
            string alderString = Console.ReadLine();
            int alder = int.Parse(alderString);

            string message = "";

            if (alder >= 0 && alder <= 12)
                message = "et barn";
            else if (alder >= 13 && alder <= 19)
                message = "en teenager";
            else if (alder >= 20 && alder <= 25)
                message = "en studerende";
            else if (alder >= 26 && alder <= 67)
                message = "i arbejde";
            else if (alder > 67)
                message = "en pensionist";
            else
            {
                Console.WriteLine("Entered age not valid!");
                Console.WriteLine("Exiting...");
                Console.ReadLine();
                Environment.Exit(1);
            }

            Console.WriteLine("{0} er {1} år gammel og er {2}", navn, alder, message);
        }
    }
}
