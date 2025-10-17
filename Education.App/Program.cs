using System.Runtime.CompilerServices;
using Education.Domain;

namespace Education.Client;

class Program
{
    static void Main()
    {



        var L1 = new Teacher("Kidde", "Ottosson", "073-8765425", "1968-03-25", new Address { AddressLine = "Torparvägen 17", PostalCode = "219 47", Region = "Flyinge" }, "Träslöjd");
        var L2 = new Teacher("Åsa-Katarina", "Bärnfeldt", "073-9875654", "1989-09-13", new Address { AddressLine = "Storgatan 5", PostalCode = "210 30", Region = "Lund" }, "Matematik");

        var student = new Student("Ida", "Arnelund", "073-6524509", "2002-01-19", new Address { AddressLine = "Klocksvängen 34", PostalCode = "215 97", Region = "Eslöv" });


        var S2 = new Student("Kalle", "Helmund", "073-7652494", "1999-05-24", new Address { AddressLine = "Pelikanstigen 8", PostalCode = "280 90", Region = "Kävlinge" });


        Console.WriteLine(L1);
        Console.WriteLine(L2);









    }

}
