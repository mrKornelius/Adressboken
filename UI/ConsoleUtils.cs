static class ConsoleUtils
{
    internal static int GetIntChar(string prompt)
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