class Program
{
    private static void Main()
    {
        AdressBook adressBook = new();

        AddFakeData(adressBook);

        AdressBookMenu menu = new(adressBook);
        menu.Show();
    }

    private static void AddFakeData(AdressBook adressBook)
    {
        for (int i = 0; i < 100; i++)
        {
            Contact newContact = new();
            newContact.FirstName = Faker.Name.First();
            newContact.LastName = Faker.Name.Last();
            newContact.PhoneNumber = new() { Category = "Mobile", Value = Faker.Phone.Number() };
            adressBook.AddContact(newContact);
        }
    }
}