class Contact
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName { get => FirstName + " " + LastName; }
    public CategoryValue? PhoneNumber { get; set; }

    public bool Contains(string searchString)
    {
        if (FullName.Contains(searchString, StringComparison.InvariantCultureIgnoreCase)) return true;
        else if (PhoneNumber is not null && PhoneNumber.Value.Contains(searchString, StringComparison.InvariantCultureIgnoreCase)) return true;

        return false;
    }
}