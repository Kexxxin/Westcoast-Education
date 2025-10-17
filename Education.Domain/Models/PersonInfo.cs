

namespace Education.Domain;


public class PersonInfo
{

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    protected string? PhoneNumber { get; }
    protected string? SocialSecurityNumber { get; }
    public Address? Address { get; set; } = new Address();

    protected PersonInfo(string firstName, string lastName, string phoneNumber, string socialSecurityNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        SocialSecurityNumber = socialSecurityNumber;
    }



    public override string ToString()
    {
        return $"{FirstName} - {LastName} - {PhoneNumber} - {Address}";
    }

}
