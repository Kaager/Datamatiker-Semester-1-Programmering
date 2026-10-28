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

            Console.ReadLine();

        }
    }
}
