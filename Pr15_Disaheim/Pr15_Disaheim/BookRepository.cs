using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class BookRepository
    {
        private List<Book> books = new();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book? GetBook(string itemId)
        {
            foreach (Book book in books)
            {
                if (book.ItemId == itemId)
                    return book;
            }
            return null;

            // Forrige 6 linjer kan også skrives på følgende måde:
            //return Books.Find(book => book.ItemId == itemId);
        }

        public double GetTotalValue()
        {
            double totalValue = 0.0;
            Utility util = new();

            foreach (Book book in books)
            {
                totalValue += util.GetValueOfBook(book);
            }
            return totalValue;
        }

    }
}
