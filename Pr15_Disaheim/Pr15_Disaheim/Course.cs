using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class Course : IValuable
    {
        public string Name { get; set; }
        public static double CourseHourValue { get; set; } = 875.0;
        public int DurationInMinutes { get; set; }

        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }

        public Course (string name)
            : this (name, 0 )
        {
        }

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }

        public double GetValue()
        {
            int commencedTime = this.DurationInMinutes / 60;
            if ((this.DurationInMinutes % 60) > 0)
                commencedTime++;
            return CourseHourValue * commencedTime;
        }
    }
}
