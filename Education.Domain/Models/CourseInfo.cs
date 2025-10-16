using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace Education.Domain.Models
{
    public class CourseInfo
    {
        private List<Course> _courses = new List<Course>();

        public void AddCourse(Course course)
        {
            if (course == null) return;
            if (_courses.Any(x => x.CourseNumber == course.CourseNumber))
            {
                Console.WriteLine("Kursen finns redan");
            }
            _courses.Add(course);
        }

        public IEnumerable<Course> ListCourses()
        {
            return _courses;
        }


    }
}