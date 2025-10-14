namespace Education.Domain;

public class Address
{
    public string AddressLine { get; set; }
    public string PostalCode { get; set; }
    public string Region { get; set; }


    public Address()
    {
        AddressLine = "";
        PostalCode = "";
        Region = "";

    }

    public override string ToString()
    {
        return $"{AddressLine} {PostalCode} {Region}";
    }
}

