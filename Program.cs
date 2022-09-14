string contacts = "Jonas Jonasson\nSven Svensson";
string[] names = new string[0];
string[] numbers = new string[0];

while (true)
{
    Console.Clear();
    Console.WriteLine("ADRESSBOKEN");
    Console.WriteLine("1. Visa kontakter");
    Console.WriteLine("2. Lägg till kontakt");
    Console.WriteLine("3. Avsluta");

    char choice = GetChar("Välj: ");
    if (choice == '1')
    {
        Console.WriteLine("KONTAKTER");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.ReadLine();
    }
    else if (choice == '2')
    {
        Console.WriteLine("LÄGG TILL KONTAKT");
        Console.Write("Namn: ");
        // contacts += Environment.NewLine + Console.ReadLine();
        string name = Console.ReadLine();
        Console.WriteLine("Nummer: ");
        string number = Console.ReadLine();
        AddContact(name, number);
    }
    else if (choice == '3')
    {
        Console.WriteLine("AVSLUTAR...");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Välj ett alternativ i menyn och tryck enter!");
        Console.ReadLine();
    }
}

void AddContact(string name, string number)
{
    string[] newNamesArray = new string[names.Length + 1];
    for (int i = 0; i < names.Length; i++)
    {
        newNamesArray[i] = names[i];
    }
    names = newNamesArray;
    names[^1] = name;
}

static char GetChar(string prompt)
{
    Console.Write(prompt);
    while (true)
    {
        if (Console.KeyAvailable)
        {
            return Console.ReadKey(true).KeyChar;
        }
    }
}