

namespace Education.Domain;

public class Student : PersonInfo
{

    public Student(string firstName, string lastName, string phoneNumber, string socialSecurityNumber, Address address) : base(firstName, lastName, phoneNumber, socialSecurityNumber, address)
    {

    }

    public override string ToString()
    {
        return $"Elev: {FirstName} {LastName}, Adress: {Address?.AddressLine}, Postnummer: {Address?.PostalCode}, Ort: {Address?.Region}";
    }





}
