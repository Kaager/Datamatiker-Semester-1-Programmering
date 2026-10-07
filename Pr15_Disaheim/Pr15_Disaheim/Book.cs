using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class Book
    {
        // Fields
        private string _itemID;
        private string _title;
        private double _price;

        // Properties
        public string ItemID
        {
            get => _itemID;
            set => _itemID = value;
        }
        public string Title
        {
            get => _title;
            set => _title = value;
        }
        public double Price
        {
            get => _price;
            set => _price = value;
        }

        // Constructors
        public Book(string itemID)
        {
            _itemID = itemID;
        }

        public Book(string itemID, string title)
        {
            _itemID = itemID;
            _title = title;
        }

        public Book (string itemID, string title, double price)
        {
            _itemID = itemID;
            _title = title;
            _price = price;
        }

        // Methods
        public override string ToString()
        {
            return $"ItemId: {_itemID}, Title: {_title}, Price: {_price}";
        }
    }
}
