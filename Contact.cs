class Contact
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName { get => FirstName + " " + LastName; }
    public int CountryCode { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
}