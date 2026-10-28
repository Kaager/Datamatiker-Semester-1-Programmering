using TotallySafeLib;

namespace Pr21_CustomExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int posValue = TotallySafe.GetValueAtPosition(-2);
                Console.WriteLine(posValue);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                double doNotDoit = TotallySafe.Divider(0);
                Console.WriteLine(doNotDoit);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int thisIsInt = TotallySafe.StringToInt("somestringnotint");
                Console.WriteLine(thisIsInt);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
