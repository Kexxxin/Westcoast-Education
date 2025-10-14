

namespace Education.Domain;

public class Student : PersonalInfo
{
    public List<Course> Courses { get; set; } = new List<Course>();
    public Student(string firstName, string lastName, string phoneNumber, string socialSecurityNumber, Address address) : base(firstName, lastName, phoneNumber, socialSecurityNumber)
    {
        Address = address;
    }

    public override string ToString()
    {
        return $"Elev: {FirstName}{LastName} - {PhoneNumber}, Adress: {Address?.AddressLine}, Postnummer: {Address?.PostalCode}, Ort: {Address?.Region}";
    }





}
