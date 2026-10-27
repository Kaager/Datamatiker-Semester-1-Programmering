using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class Amulet : Merchandise
    {
        // Fields
        public static double LowQualityValue { get; set; } = 12.5;
        public static double MediumQualityValue { get; set; } = 20.0;
        public static double HighQualityValue { get; set; } = 27.5;

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

        public override double GetValue()
        {
            // Switch expression
            return this.Quality switch
            {
                Level.Low => LowQualityValue,
                Level.Medium => MediumQualityValue,
                Level.High => HighQualityValue,
                _ => 0.0
            };


            // "Normal" switch case:
            /*
            switch (amulet.Quality)
            {
                case Level.Low:
                    return 12.5;
                case Level.Medium:
                    return 20.0;
                case Level.High:
                    return 27.5;
                default:
                    return 0.0;
            }
            */
        }
    }
}
