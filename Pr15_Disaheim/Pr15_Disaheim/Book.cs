using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class Book
    {
        // Fields

        // Properties
        public string ItemID { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        // Constructors
        public Book (string itemID, string title, double price)
        {
            ItemID = itemID;
            Title = title;
            Price = price;
        }
        

        public Book(string itemID, string title) :
            this (itemID, title, 0)
        {
        }
        public Book(string itemID) : 
            this(itemID, string.Empty, 0)
        {
        }

        // Methods
        public override string ToString()
        {
            return $"ItemId: {ItemID}, Title: {Title}, Price: {Price}";
        }
    }
}
