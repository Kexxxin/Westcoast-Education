using System.Runtime.CompilerServices;
using Education.Application;
using Education.Domain;

namespace Education.Client;

class Program
{
    static void Main()
    {

        string path = $"{Environment.CurrentDirectory}/Data/courseInfo.json";

        var service = new CourseService(path);
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();



        var T1 = new Teacher("Kidde", "Ottosson", "073-8765425", "1968-03-25", new Address { AddressLine = "Torparvägen 17", PostalCode = "219 47", Region = "Flyinge" }, "Träslöjd");
        var T2 = new Teacher("Åsa-Katarina", "Bärnfeldt", "073-9875654", "1989-09-13", new Address { AddressLine = "Storgatan 5", PostalCode = "210 30", Region = "Lund" }, "Matematik");

        var S1 = new Student("Ida", "Arnelund", "073-6524509", "2002-01-19", new Address { AddressLine = "Klocksvängen 34", PostalCode = "215 97", Region = "Eslöv" });
        var S2 = new Student("Kalle", "Helmund", "073-7652494", "1999-05-24", new Address { AddressLine = "Pelikanstigen 8", PostalCode = "280 90", Region = "Kävlinge" });

        var C1 = new Course("A301", "Träslöjd", "8 Veckor", new DateOnly(2025, 1, 6), new DateOnly(2025, 3, 6)) { IsClassroom = true };
        var C3 = new Course("A107", "Matematik", "24 Veckor", new DateOnly(2025, 3, 12), new DateOnly(2025, 9, 15)) { IsClassroom = true };
        var C2 = new Course("A204", "Biologi", "16 Veckor", new DateOnly(2025, 10, 1), new DateOnly(2026, 2, 12)) { IsClassroom = false };

        students.Add(S1);
        students.Add(S2);

        service.AddCourse(C1);
        service.AddCourse(C2);
        service.AddCourse(C3);

        teachers.Add(T1);
        teachers.Add(T2);

        var courses = service.GetCourses();

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Aktuella kurser:");

        foreach (var c in courses)
        {
            Console.WriteLine(c);
        }
        Console.ResetColor();

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Aktuella studenter:");

        foreach (var s in students)
        {
            Console.WriteLine(s);
        }
        Console.ResetColor();

        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Aktuella lärare:");

        foreach (var t in teachers)
        {
            Console.WriteLine(t);
        }
        Console.ResetColor();

    }

}
