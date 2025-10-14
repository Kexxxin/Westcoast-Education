


namespace Education.Domain;



public class Teacher : Student
{
    public string? SubjectKnowledge { get; set; }
    public List<Course> CourseResponsibility { get; set; } = new();

    public Teacher(string firstName, string lastName, string phoneNumber, string socialSecurityNumber, Address address, string subjectKnowledge) : base(firstName, lastName, phoneNumber, socialSecurityNumber, address)
    {
        SubjectKnowledge = subjectKnowledge;

    }

    public void CourseAssigned(Course courseNumber)
    {
        if (!CourseResponsibility.Contains(courseNumber))
            CourseResponsibility.Add(courseNumber);


    }

    public override string ToString()
    {
        return $"Lärare:{FirstName} {LastName} - {PhoneNumber} -{SocialSecurityNumber} - Adress: {Address?.AddressLine}, Postnummer: {Address?.PostalCode}, Ort: {Address?.Region} {SubjectKnowledge}";
    }

    internal void CourseAssigned(string courseNumber)
    {
        throw new NotImplementedException();
    }
}

