class AdressBookMenu
{
    readonly AdressBook _adressbook;
    public AdressBookMenu(AdressBook ab) => _adressbook = ab;

    public void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(" - ADRESSBOKEN -\n\n1. Visa kontakter \n2. Lägg till kontakt\n3. Sök bland kontakter \n4. Avsluta\n");

            int choice = ConsoleUtils.GetIntChar("> ");

            switch (choice)
            {
                case 1:
                    ShowContacts(_adressbook.GetAllContacts());
                    break;

                case 2:
                    Console.WriteLine("LÄGG TILL NY KONTAKT");

                    Contact newContact = new()
                    {
                        FirstName = ConsoleUtils.GetString("Förnamn: "),
                        LastName = ConsoleUtils.GetString("Efternamn: "),
                        PhoneNumber = new() { Category = Category.Mobile, Value = ConsoleUtils.GetString("Telefonnummer: ") }
                    };

                    _adressbook.AddContact(newContact);
                    Console.WriteLine("Kontakt tillagd!");
                    break;

                case 3:
                    ShowContacts(_adressbook.Search(ConsoleUtils.GetString("Sökterm: ")));
                    break;

                case 4:
                    Environment.Exit(0);
                    break;
            }

            Console.ReadKey();
        }
    }

    static void ShowContacts(IEnumerable<Contact> contacts)
    {
        Console.WriteLine(contacts.Count() + " KONTAKTER");
        foreach (var contact in contacts)
        {
            Console.WriteLine(contact.Id + ": " +
                              contact.FullName + " - " +
                              contact.PhoneNumber?.Value);
        }
    }
}