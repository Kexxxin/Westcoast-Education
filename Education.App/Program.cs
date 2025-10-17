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



        var L1 = new Teacher("Kidde", "Ottosson", "073-8765425", "1968-03-25", new Address { AddressLine = "Torparvägen 17", PostalCode = "219 47", Region = "Flyinge" }, "Träslöjd");
        var L2 = new Teacher("Åsa-Katarina", "Bärnfeldt", "073-9875654", "1989-09-13", new Address { AddressLine = "Storgatan 5", PostalCode = "210 30", Region = "Lund" }, "Matematik");

        var S1 = new Student("Ida", "Arnelund", "073-6524509", "2002-01-19", new Address { AddressLine = "Klocksvängen 34", PostalCode = "215 97", Region = "Eslöv" });
        var S2 = new Student("Kalle", "Helmund", "073-7652494", "1999-05-24", new Address { AddressLine = "Pelikanstigen 8", PostalCode = "280 90", Region = "Kävlinge" });

        var C1 = new Course("A1", "Träslöjd", "8 Veckor", new DateTime(2025, 1, 6), new DateTime(2025, 3, 6)) { IsClassroom = true };
        var C2 = new Course("A4", "Biologi", "16 Veckor", new DateTime(2025, 10, 9), new DateTime(2026, 2, 12)) { IsClassroom = false };

        C1.AddStudent(S1);
        C1.AddStudent(S2);

        L1.AssignCourse(C1);

        service.AddCourse(C1);
        service.AddCourse(C2);

        var courses = service.GetCourses();

        foreach (var c in courses)
        {
            Console.WriteLine(c);
        }



















    }

}
