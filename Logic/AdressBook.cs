using System.Collections.ObjectModel;

class AdressBook
{
    public int Count { get => _listOfContacts.Count; }

    readonly List<Contact> _listOfContacts = new();

    public void AddContact(Contact contact)
    {
        //Sätt id till 0 om det inte finns några contacts redan, annars till det högst id:t plus ett
        contact.Id = _listOfContacts.Count > 0 ? _listOfContacts.Max(c => c.Id) + 1 : 0;
        _listOfContacts.Add(contact);
    }

    public ReadOnlyCollection<Contact> GetAllContacts()
    {
        return new ReadOnlyCollection<Contact>(_listOfContacts);
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