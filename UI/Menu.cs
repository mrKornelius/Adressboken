class AdressBookMenu
{
    AdressBook _adressbook;

    internal AdressBookMenu(AdressBook ab)
    {
        _adressbook = ab;
    }

    internal void Show()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("ADRESSBOKEN");
            Console.WriteLine("1. Visa kontakter");
            Console.WriteLine("2. Lägg till kontakt");
            Console.WriteLine("3. Avsluta");

            int choice = ConsoleUtils.GetIntChar("Välj: ");

            if (choice == 1)
            {
                Console.WriteLine("KONTAKTER");
                foreach (var contact in _adressbook.GetAllContacts())
                {
                    Console.WriteLine(contact.FullName + Environment.NewLine + contact.PhoneNumber + Environment.NewLine);
                }
                Console.ReadLine();
            }
            else if (choice == 2)
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
            else if (choice == 3)
            {
                Console.WriteLine("AVSLUTAR...");
                _adressbook.Save();
                Environment.Exit(0);
            }
        }

    }
}