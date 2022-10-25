using System.Collections.ObjectModel;

class AdressBook
{
    public int Count { get => _listOfContacts.Count; }

    readonly List<Contact> _listOfContacts = new();

    public void AddContact(Contact contact)
    {
        int maxId = 0;
        if (_listOfContacts.Count > 0) maxId = _listOfContacts.Max(c => c.Id);
        contact.Id = maxId + 1;
        _listOfContacts.Add(contact);
    }

    public List<Contact> GetContacts()
    {
        return new List<Contact>(_listOfContacts);
    }

    public ReadOnlyCollection<Contact> GetAllContacts()
    {
        return new ReadOnlyCollection<Contact>(_listOfContacts);
    }

    public List<Contact> GetAllElvis()
    {
        return Search("elvis");
    }

    public List<Contact> Search(string searchString)
    {
        List<Contact> searchResult = new();

        foreach (Contact currentContact in _listOfContacts)
        {
            if (currentContact.FullName.Contains(searchString, StringComparison.InvariantCultureIgnoreCase))
            {
                searchResult.Add(currentContact);
            }
        }

        return searchResult;
    }
}