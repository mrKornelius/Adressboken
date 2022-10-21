class Program
{
    private static void Main()
    {
        AdressBook adressBook = new();

        adressBook.AddContact(new() { FirstName = "Gun", LastName = "Gunsson", PhoneNumber = new CategoryValue() { Category = "Mobile", Value = "0701234567" } });
        adressBook.AddContact(new() { FirstName = "Alva", LastName = "Bolund", PhoneNumber = new CategoryValue() { Category = "Mobile", Value = "0739876544" } });
        adressBook.AddContact(new() { FirstName = "Lars", LastName = "Svensson", PhoneNumber = new CategoryValue() { Category = "Mobile", Value = "070123321654" } });
        adressBook.AddContact(new() { FirstName = "Maj", LastName = "Britt", PhoneNumber = new CategoryValue() { Category = "Mobile", Value = "076098763456" } });
        adressBook.AddContact(new() { FirstName = "Sven", LastName = "Larsson", PhoneNumber = new CategoryValue() { Category = "Mobile", Value = "01033335544" } });

        AdressBookMenu menu = new(adressBook);
        menu.Show();
    }
}