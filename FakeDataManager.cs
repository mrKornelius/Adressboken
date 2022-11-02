class FakeDataManager : IDataManager
{
    public List<Contact> Load()
    {
        List<Contact> newList = new();

        for (int i = 0; i < 1000; i++)
        {
            Contact newContact = new()
            {
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                PhoneNumber = new() { Category = Category.Work, Value = Faker.Phone.Number() }
            };

            newList.Add(newContact);
        }

        return newList;
    }

    public void Save(List<Contact> contacts)
    {
        Console.WriteLine("Saving data!  ...not");
    }
}