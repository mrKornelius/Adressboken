class SQLDataManager : IDataManager
{
    public List<Contact> Load()
    {
        //Doing dapper magic
        return new List<Contact>();
    }

    public void Save(List<Contact> contacts)
    {
        Console.WriteLine("Saving to SQLServer!");
    }
}