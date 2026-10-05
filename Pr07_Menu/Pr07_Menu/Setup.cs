using System;
using System.Collections.Generic;
using System.Text;

namespace Pr07_Menu
{
    internal static class Setup
    {
        public static Menu CreateMenu()
        {
            Menu mainMenu = new Menu("Min fantastiske menu");

            // First menu item
            string someTitle = "1. Gør dit";
            mainMenu.AddMenuItem(someTitle);

            // Second menu item
            someTitle = "2. Gør dat";
            mainMenu.AddMenuItem(someTitle);

            // Third menu item
            someTitle = "3. Gør noget";
            mainMenu.AddMenuItem(someTitle);

            // Last menu item
            someTitle = "4. Få svaret på livet, universet og alting";
            mainMenu.AddMenuItem(someTitle);

            return mainMenu;
        }
    }
}
