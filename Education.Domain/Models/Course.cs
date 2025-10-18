using System.Net.Mail;

namespace Education.Domain;

public class Course
{
    public string CourseNumber { get; set; }
    public string CourseName { get; set; }
    public string CourseLength { get; set; }
    public DateOnly CourseStart { get; set; }
    public DateOnly CourseEnd { get; set; }
    public bool IsClassroom { get; set; }

    public Course(string courseNumber, string courseName, string courseLength, DateOnly courseStart, DateOnly courseEnd)
    {
        CourseNumber = courseNumber;
        CourseName = courseName;
        CourseLength = courseLength;
        CourseStart = courseStart;
        CourseEnd = courseEnd;

    }

    public override string ToString()
    {
        string EducationType = IsClassroom ? "Klassrum" : "Distans";
        return $"{CourseNumber} - {CourseName} - {EducationType} - Längd: {CourseLength} - Kursstart: {CourseStart} - Kursavslutning: {CourseEnd}";
    }



}
