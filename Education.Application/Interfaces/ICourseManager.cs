using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Education.Application.Interfaces
{
    public interface ICourseManager
    {
        void AddCourse(Course C);
        void ListCourses();
        void ListAllStudents();
        void Save();
        void Load();
    }
}