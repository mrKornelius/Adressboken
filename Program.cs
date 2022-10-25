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
        for (int i = 0; i < 1000; i++)
        {
            Contact newContact = new()
            {
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                PhoneNumber = new() { Category = Category.Work, Value = Faker.Phone.Number() }
            };
            adressBook.AddContact(newContact);
        }
    }
}