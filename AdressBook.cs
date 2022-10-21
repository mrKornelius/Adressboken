using System.Collections.Generic;
using System.Collections.ObjectModel;

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
}