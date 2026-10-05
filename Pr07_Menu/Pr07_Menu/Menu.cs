using System;
using System.Collections.Generic;
using System.Text;

namespace Pr07_Menu
{
    internal class Menu
    {
        public string Title;
        private MenuItem[] _menuItems = new MenuItem[69];
        private int _itemCount = 0;

        public Menu(string Title)
        {
            this.Title = Title;
        }

        public int ItemCount => _itemCount;

        public void Show()
        {
            Console.WriteLine(Title);
            Console.WriteLine();
            for (int i = 0; i < _itemCount; i++)
            {
                Console.WriteLine($"{_menuItems[i].Title}");
            }
            Console.WriteLine();
            Console.WriteLine("(Tryk menupunk eller 0 for at afslutte)");
        }

        public void AddMenuItem(string menuTitle)
        {
            MenuItem newItem = new(menuTitle);
            _menuItems[_itemCount] = newItem;
            _itemCount++;
        }
    }
}
