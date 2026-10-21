using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses = new();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course? GetCourse(string name)
        {
            return courses.Find(someCourse => someCourse.Name == name);
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            Utility util = new();

            foreach (Course course in courses)
            {
                totalValue += util.GetValueOfCourse(course);
            }
            return totalValue;
        }
    }
}
