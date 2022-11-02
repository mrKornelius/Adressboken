interface IDataManager
{
    public void Save(List<Contact> contacts);
    public List<Contact> Load();
}