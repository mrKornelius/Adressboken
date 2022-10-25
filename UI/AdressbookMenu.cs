class AdressBookMenu
{
    AdressBook _adressbook;

    public AdressBookMenu(AdressBook ab)
    {
        _adressbook = ab;
    }

    public void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(" - ADRESSBOKEN -\n\n1. Visa kontakter \n2. Lägg till kontakt");
            Console.WriteLine("3. Sök bland kontakter \n4. Avsluta\n");

            int choice = ConsoleUtils.GetIntChar("> ");

            switch (choice)
            {
                case 1:
                    ShowContacts();
                    break;

                case 2:
                    AddContacts();
                    break;

                case 3:
                    SearchContacts();
                    break;

                default:
                    Quit();
                    break;
            }
        }
    }

    private void SearchContacts()
    {
        Console.Write("Sökning: ");
        string searchString = Console.ReadLine();

        List<Contact> result = _adressbook.Search(searchString);

        foreach (Contact currentContact in result)
        {
            Console.WriteLine(currentContact.Id + " " +
                              currentContact.FullName + " " +
                              currentContact.PhoneNumber.Value);
        }

        Console.ReadKey();
    }

    private void Quit()
    {
        Console.WriteLine("AVSLUTAR...");
        Environment.Exit(0);
    }

    private void AddContacts()
    {
        Console.WriteLine("LÄGG TILL KONTAKT");
        Contact newContact = new();

        Console.Write("Förnamn: ");
        newContact.FirstName = Console.ReadLine() ?? "";

        Console.Write("Efernamn: ");
        newContact.LastName = Console.ReadLine() ?? "";

        Console.Write("Telefonnummer: ");
        newContact.PhoneNumber = new() { Category = "Mobile", Value = Console.ReadLine() ?? "" };

        _adressbook.AddContact(newContact);
    }

    private void ShowContacts()
    {
        Console.WriteLine("KONTAKTER");
        foreach (var contact in _adressbook.GetAllContacts())
        {
            Console.WriteLine(contact.Id + Environment.NewLine +
                              contact.FullName + Environment.NewLine +
                              contact.PhoneNumber?.Value + Environment.NewLine);
        }
        Console.ReadLine();
    }
}