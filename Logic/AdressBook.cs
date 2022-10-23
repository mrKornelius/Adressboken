using System.Collections.ObjectModel;

class AdressBook
{
    public int Count { get => _listOfContacts.Count; }

    readonly List<Contact> _listOfContacts = new();

    public void AddContact(Contact contact)
    {
        int maxId = _listOfContacts.Max(c => c.Id);
        contact.Id = maxId + 1;
        _listOfContacts.Add(contact);
    }

    public ReadOnlyCollection<Contact> GetAllContacts()
    {
        return new ReadOnlyCollection<Contact>(_listOfContacts);
    }

    public void Search()
    {

    }
}