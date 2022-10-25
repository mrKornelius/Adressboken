static class ConsoleUtils
{
    internal static int GetIntChar(string prompt)
    {
        int parsedInt;

        do
        {
            Console.CursorLeft = 0;
            Console.Write(prompt);
        }
        while (int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out parsedInt) == false);

        return parsedInt;
    }

    internal static string GetString(string prompt)
    {
        string result;

        do
        {
            Console.CursorLeft = 0;
            Console.Write(prompt);
            result = Console.ReadLine() ?? string.Empty;
        }
        while (string.IsNullOrWhiteSpace(result));

        return result;
    }
}