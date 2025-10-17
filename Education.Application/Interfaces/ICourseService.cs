using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Education.Domain;

namespace Education.Application.Interfaces
{
    public interface ICourseService
    {
        void AddCourse(Course course);
        void SaveCourses(List<Course> courses);
        List<Course> GetCourses();

    }
}