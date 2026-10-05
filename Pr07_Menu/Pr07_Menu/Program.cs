using static Pr07_Menu.Setup;
namespace Pr07_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = CreateMenu();
            bool runMainMenu = true;

            
            while (runMainMenu)
            {
                RunMainMenu(mainMenu);
            }

            Console.ReadLine();

        }

        static void RunMainMenu(Menu mainMenu)
        {
            Console.Clear();
            mainMenu.Show();

            bool run = true;
            int userChoice = Helpers.GetChoiceInRange(mainMenu.ItemCount);

            switch (userChoice)
            {
                case 0:
                    run = false;
                    break;
                case 1:
                    Console.WriteLine("Gør dit!");
                    break;
                case 2:
                    Console.WriteLine("Gør dat");
                    break;
                case 3:
                    Console.WriteLine("Gør noget");
                    break;
                case 4:
                    Console.WriteLine("42");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
