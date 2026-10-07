using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class Amulet
    {
        // Fields
        private string _itemID;
        private string _design;
        private Level _quality;

        // Properties
        public string ItemID
        {
            get => _itemID;
            set => _itemID = value;
        }

        public string Design
        {
            get => _design;
            set => _design = value;
        }

        public Level Quality
        {
            get => _quality;
            set => _quality = value;
        }

        // Constructors
        public Amulet(string itemID, Level quality, string desing)
        {
            _itemID = itemID;
            _quality = quality;
            _design = desing;
        }

        public Amulet(string itemID, Level quality) :
            this (itemID, quality, string.Empty)
        {
        }
        public Amulet(string itemID) :
            this (itemID, Level.Medium, string.Empty)
        {
        }

        // Methods
        public override string ToString()
        {
            return $"ItemId: {_itemID}, Quality: {_quality}, Design: {_design}";
        }

    }
}
