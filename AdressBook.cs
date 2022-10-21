using System.Collections.ObjectModel;
using System.Text.Json;

class AdressBook
{
    readonly List<Contact> _contacts = new();

    public void AddContact(Contact contact)
    {
        int lastId = 0;
        _contacts.ForEach(c => lastId = c.Id > lastId ? c.Id : lastId);
        contact.Id = lastId + 1;
        _contacts.Add(contact);
    }

    public ReadOnlyCollection<List<Contact>> GetAllContacts()
    {
        return new ReadOnlyCollection<List<Contact>>((IList<List<Contact>>)_contacts);
    }

    private void SaveData()
    {
        string jsonData = JsonSerializer.Serialize(_contacts);
        File.WriteAllText("contacts.json", jsonData);
    }
}