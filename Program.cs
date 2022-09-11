string contacts = "Jonas Jonasson\nSven Svensson";

while (true)
{
    Console.Clear();
    Console.WriteLine("ADRESSBOKEN");
    Console.WriteLine("1. Visa kontakter");
    Console.WriteLine("2. Lägg till kontakt");
    Console.WriteLine("3. Avsluta");

    int choice = ReadLineInt("Välj: ");
    if (choice == 1)
    {
        Console.WriteLine("KONTAKTER");
        Console.WriteLine(contacts);
        Console.ReadLine();
    }
    else if (choice == 2)
    {
        Console.WriteLine("LÄGG TILL KONTAKT");
        Console.Write("Namn: ");
        contacts += Environment.NewLine + Console.ReadLine();
    }
    else if (choice == 3)
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

static int ReadLineInt(string prompt)
{
    int result;
    bool success;
    do
    {
        Console.Write(prompt);
        success = int.TryParse(Console.ReadLine(), out result);
    }
    while (!success);
    return result;
}