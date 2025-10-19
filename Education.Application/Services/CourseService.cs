namespace Education.Application;

using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using Education.Application.Interfaces;
using Education.Domain;
using Education.Persistence;

public class CourseService : ICourseService
{
    public List<Course> courses = new List<Course>();
    private readonly string _path;
    private readonly FileStorage _fileStorage = new();
    private static JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };

    public CourseService(string path)
    {
        _path = path;
    }

    public List<Course> GetCourses()
    {
        var json = _fileStorage.ReadJson(_path);

        if (string.IsNullOrWhiteSpace(json))
            return new List<Course>();



        var courses = JsonSerializer.Deserialize<List<Course>>(json, _options);
        return courses ?? new List<Course>();



    }


    public void AddCourse(Course course)
    {
        if (course == null) return;
        if (string.IsNullOrWhiteSpace(course.CourseNumber)) return;

        var currentCourses = GetCourses() ?? new List<Course>();

        foreach (var c in currentCourses)
        {
            if (c.CourseNumber == course.CourseNumber)
                return;
        }

        currentCourses.Add(course);
        SaveCourses(currentCourses);

    }

    public void SaveCourses(List<Course> courses)
    {
        var json = JsonSerializer.Serialize(courses, _options);
        _fileStorage.WriteJson(_path, json);


    }


}
