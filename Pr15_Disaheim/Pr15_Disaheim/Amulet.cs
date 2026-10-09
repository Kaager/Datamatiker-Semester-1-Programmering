using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class Amulet : Merchandise
    {
        // Fields

        // Properties
        public string Design { get; set; }

        public Level Quality { get; set; }

        // Constructors
        public Amulet(string itemID, Level quality, string desing)
           // : base(itemID)
        {
            ItemId = itemID;
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
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }

    }
}
