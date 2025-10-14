using Education.Domain;

namespace Education.Client;

class Program
{
    static void Main()
    {

        var Lärare1 = new Teacher("Axel", "Bärnfeldt", "073-9875654", "1968-03-25", new Address { AddressLine = "Storgatan 5", PostalCode = "215 30", Region = "Markaryd" }, "Matematik");

        Console.WriteLine(Lärare1);







    }

}
