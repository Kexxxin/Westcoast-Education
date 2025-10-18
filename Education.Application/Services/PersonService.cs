using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Education.Domain;

namespace Education.Application.Services
{
    public class PersonService
    {
        public List<Student> students { get; } = new List<Student>();
        public List<Teacher> teachers { get; set; } = new List<Teacher>();

        public void AddStudent(Student s)
        {
            if (s == null) return;
            students.Add(s);
        }
        public void AddTeacher(Teacher t)
        {
            if (t == null) return;
            teachers.Add(t);

        }
    }
}