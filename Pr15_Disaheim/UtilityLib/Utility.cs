using Pr15_Disaheim;
using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLib
{
    public  class Utility
    {
        public  double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public  double GetValueOfAmulet(Amulet amulet)
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

        public double GetValueOfCourse(Course course)
        {
            int commencedTime = course.DurationInMinutes / 60;
            if ((course.DurationInMinutes % 60) > 0)
                commencedTime++;
            return 875.00 * commencedTime;
        }
    }
}
