using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public  class Utility
    {
        public double Low { get; set; } = 12.5;
        public double Medium { get; set; } = 20.0;
        public double High { get; set; } = 27.5;
        public double PricePerHour { get; set; } = 875.0;
        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Book aBook)
            {
                return GetValueOfBook(aBook);
            }
            else if (merchandise is Amulet anAmulet)
            {
                return GetValueOfAmulet(anAmulet);
            }
            else
                throw new NotSupportedException($"Merchandise type '{merchandise.GetType().Name}' is not supported.");
        }
        private double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        private double GetValueOfAmulet(Amulet amulet)
        {
            // Switch expression
            return amulet.Quality switch
            {
                Level.Low => Low,
                Level.Medium => Medium,
                Level.High => High,
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

        public double GetValueOfCourse(Course course)
        {
            int commencedTime = course.DurationInMinutes / 60;
            if ((course.DurationInMinutes % 60) > 0)
                commencedTime++;
            return PricePerHour * commencedTime;
        }
    }
}
