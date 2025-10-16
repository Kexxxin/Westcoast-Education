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
        void SaveCourse(Course course);
        List<Course> LoadCourse();



    }
}