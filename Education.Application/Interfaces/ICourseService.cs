using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Education.Domain.Models;

namespace Education.Application.Interfaces
{
    public interface ICourseService
    {
        List<Course> FetchCourses();
        void SaveCourses(List<Course> courses);



    }
}