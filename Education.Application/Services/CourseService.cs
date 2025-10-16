namespace Education.Application;

using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using Education.Application.Interfaces;

public class CourseService : ICourseService
{
    private readonly string _path = path;
    private readonly JsonStorage _jsonStorage = new();
    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };

    public Course GetCourses()
    {
        var json = _jsonStorage.Read(path);
        var course = JsonSerializer.Deserialize<Course>(json, _options);
        return course;
    }

    public void SaveCourse(Course course)
    {
        var json = JsonSerializer.Serialize(course, _options);
        _jsonStorage.Write(_path, json);
    }




}
