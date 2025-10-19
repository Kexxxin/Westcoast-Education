



namespace Education.Domain;



public class Teacher : PersonInfo
{
    public string? SubjectKnowledge { get; set; }
    public List<Course> CourseResponsibility { get; set; } = new();

    public Teacher(string firstName, string lastName, string phoneNumber, string socialSecurityNumber, Address address, string subjectKnowledge) : base(firstName, lastName, phoneNumber, socialSecurityNumber, address)
    {
        SubjectKnowledge = subjectKnowledge;

    }

    public void AssignCourse(Course course)
    {
        if (!CourseResponsibility.Contains(course))
            CourseResponsibility.Add(course);


    }

    public override string ToString()
    {
        return $"Lärare: {FirstName} {LastName}, {SocialSecurityNumber}, Adress: {Address?.AddressLine}, Postnummer: {Address?.PostalCode}, Ort: {Address?.Region} - {SubjectKnowledge}";
    }


}

