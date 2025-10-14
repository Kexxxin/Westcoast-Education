namespace Education.Application;

public class CourseTaskManager
{

    private readonly List<Course> _courses = new List<Course>();
    public IEnumerable<Course> Courses => _courses;
    public List<Course> ListCourses();
    public List<Student> ListAllStudents();
    public Course AddCourse(Course course)
    {

        _courses.Add(course);
    }


}
