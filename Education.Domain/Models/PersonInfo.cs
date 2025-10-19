

namespace Education.Domain;


public class PersonInfo
{

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    protected string? PhoneNumber { get; }
    protected string? SocialSecurityNumber { get; }
    public Address? Address { get; set; }

    protected PersonInfo(string firstName, string lastName, string phoneNumber, string socialSecurityNumber, Address address)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        SocialSecurityNumber = socialSecurityNumber;
        Address = address;
    }



    public override string ToString()
    {
        return $"{FirstName} - {LastName} - {PhoneNumber} - {Address}";
    }

}
