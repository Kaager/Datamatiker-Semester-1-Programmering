using System.Globalization;
namespace TheFirstOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast navn: ");
            string firstName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());

            Console.Write("Indtast efternavn: ");
            string lastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());

            Console.Write("Indtast alder: ");
            string age = Console.ReadLine();

            Console.Clear();


            //Console.WriteLine();
            Console.WriteLine("Fornavn: " + firstName);
            Console.WriteLine("Efternavn: " + lastName);
            Console.WriteLine("Fulde navn: " + firstName + " " + lastName);
            Console.WriteLine("Alder: " + age);

            Console.WriteLine("{0} {1} er {2} år gammel.", firstName, lastName, age);

            Console.ReadLine();
        }
    }
}
