using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public static class Utility
    {
        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public static double GetValueOfAmulet(Amulet amulet)
        {
            // Switch expression
            return amulet.Quality switch
            {
                Level.Low => 12.5,
                Level.Medium => 20.0,
                Level.High => 27.5,
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
