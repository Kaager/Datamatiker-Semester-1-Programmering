using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class Amulet
    {
        // Fields

        // Properties
        public string ItemID { get; set; }

        public string Design { get; set; }

        public Level Quality { get; set; }

        // Constructors
        public Amulet(string itemID, Level quality, string desing)
        {
            ItemID = itemID;
            Quality = quality;
            Design = desing;
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
            return $"ItemId: {ItemID}, Quality: {Quality}, Design: {Design}";
        }

    }
}
