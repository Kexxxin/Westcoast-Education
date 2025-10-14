namespace Education.Domain;

public class EducationLeader : Teacher
{
    public DateTime DateOfEmployment { get; set; }
    public EducationLeader(string firstName, string lastName, string phoneNumber, string socialSecurityNumber, Address address, string subjectKnowledge, DateTime dateOfEmployment) : base(firstName, lastName, phoneNumber, socialSecurityNumber, address, subjectKnowledge)
    {
        DateOfEmployment = dateOfEmployment;
    }
    public override string ToString()
    {
        return $"Utbildningsledare: {FirstName} {LastName} - {SubjectKnowledge} - Anställd: {DateOfEmployment:yyyy-MM-dd}";
    }

}
