using System.Net.Mail;

namespace Education.Domain;

public class Course
{
    public string CourseNumber { get; set; } = "";
    public string CourseName { get; set; } = "";
    public string CourseLength { get; set; } = "";
    public DateTime CourseStart { get; set; }
    public DateTime CourseEnd { get; set; }
    public bool IsClassroom { get; set; }
    public List<Student> Students { get; } = new List<Student>();
    public List<Teacher> Teachers { get; set; } = new List<Teacher>();

    protected Course(string courseNumber, string courseName, string courseLength, DateTime courseStart, DateTime courseEnd)
    {
        CourseNumber = courseNumber;
        CourseName = courseName;
        CourseLength = courseLength;
        CourseStart = courseStart;
        CourseEnd = courseEnd;

    }
    public void AddStudent(Student s)
    {
        Students.Add(s);
    }
    public void AddTeacher(Teacher t)
    {
        Teachers.Add(t);
        t.CourseAssigned(CourseNumber);
    }
    public override string ToString()
    {
        string EducationType = IsClassroom ? "Klassrum" : "Distans";
        return $"{CourseNumber} {CourseName} ({EducationType} Längd: {CourseLength} Kursstart: {CourseStart} Kursavslutning: {CourseEnd})";
    }



}
