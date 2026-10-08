using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class Controller
    {
        public List<Book> Books { get; set; }
        public List<Amulet> Amulets { get; set; }

        public Controller()
        {
            Books = new();
            Amulets = new();
            // Both can use this syntax:
            //Books = [];
            //Amulets = [];
        }

        public void AddToList(Book book)
        {
            Books.Add(book);
        }

        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
    }
}
