using System.Runtime.CompilerServices;
using Education.Domain;

namespace Education.Client;

class Program
{
    static void Main()
    {

        var L1 = new Teacher("Kidde", "Ottosson", "073-8765425", "1968-03-25", new Address { AddressLine = "Torparvägen 17", PostalCode = "219 47", Region = "Markaryd" }, "Träslöjd");
        var L2 = new Teacher("Åsa-Katarina", "Bärnfeldt", "073-9875654", "1989-09-13", new Address { AddressLine = "Storgatan 5", PostalCode = "210 30", Region = "Lund" }, "Matematik");


        Console.WriteLine(L1);
        Console.WriteLine(L2);

        // Bestämma sig för interface och taskmanager
        // interaktiv eller ej?
        // fixa json







    }

}
