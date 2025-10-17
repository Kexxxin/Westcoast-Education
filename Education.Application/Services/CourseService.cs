namespace Education.Application;

using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using Education.Application.Interfaces;

public class CourseService : ICourseService
{
    private readonly string _path = path;
    private readonly FileStorage _fileStorage = new();
    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };

    public List<Course> FetchCourses()
    {
        var json = _fileStorage.ReadJsonlist(_path);
        var courses = JsonSerializer.Deserialize<List<Course>>(json, _options);
        return courses ?? [];
    }


    public void AddCourse(Course course)
    {

        Courses = FetchCourses();
        Courses.Add(course);
        SaveCourses(courses);
        var json = _jsonStorage.Read(path);
        var json = JsonSerializer.Serialize(Courses, _options);
        _filestorage.WriteJson(_path, json);
    }

    public void SaveCourse(Course course)
    {
        var json = JsonSerializer.Serialize(courses, _options);
        _fileStorage.Write(_path, json);
    }




}
