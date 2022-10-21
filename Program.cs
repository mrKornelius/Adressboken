internal class Program
{
    private static void Main(string[] args)
    {
        AdressBook adressBook = new();
        AddTestData(adressBook);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("ADRESSBOKEN");
            Console.WriteLine("1. Visa kontakter");
            Console.WriteLine("2. Lägg till kontakt");
            Console.WriteLine("3. Avsluta");

            int choice = GetIntChar("Välj: ");

            if (choice == 1)
            {
                Console.WriteLine("KONTAKTER");
                foreach (var contact in adressBook.GetAllContacts())
                {
                    Console.WriteLine(contact.FullName + Environment.NewLine + contact.PhoneNumber);
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
                newContact.PhoneNumber = Console.ReadLine() ?? "";
                adressBook.AddContact(newContact);
            }
            else if (choice == 3)
            {
                Console.WriteLine("AVSLUTAR...");
                adressBook.Save();
                Environment.Exit(0);
            }
        }

        static int GetIntChar(string prompt)
        {
            Console.Write(prompt);

            int parsedInt;

            while (true)
            {
                var input = Console.ReadKey(true).KeyChar;
                if (int.TryParse(input.ToString(), out parsedInt)) break;
            }

            return parsedInt;
        }
    }

    private static void AddTestData(AdressBook adressBook)
    {
        adressBook.AddContact(new() { FirstName = "Gun", LastName = "Gunsson", PhoneNumber = "0701234567", CountryCode = 46 });
        adressBook.AddContact(new() { FirstName = "Alva", LastName = "Bolund", PhoneNumber = "0739876544", CountryCode = 46 });
        adressBook.AddContact(new() { FirstName = "Lars", LastName = "Svensson", PhoneNumber = "070123321654", CountryCode = 46 });
        adressBook.AddContact(new() { FirstName = "Maj", LastName = "Britt", PhoneNumber = "076098763456", CountryCode = 46 });
        adressBook.AddContact(new() { FirstName = "Sven", LastName = "Larsson", PhoneNumber = "01033335544", CountryCode = 46 });
    }
}