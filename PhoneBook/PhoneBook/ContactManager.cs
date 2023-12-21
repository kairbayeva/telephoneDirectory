using System;
using System.Collections.Generic;
using System.Linq;

public class ContactManager
{
    private List<Contact> contacts = new List<Contact>();

    public List<Contact> Contacts => contacts;

    public void AddContact(Contact contact)
    {
        contact.Id = contacts.Count + 1;
        contacts.Add(contact);
    }

    public List<Contact> SearchContacts(string searchTerm)
    {
        searchTerm = searchTerm.ToLower();
        return contacts.Where(c =>
            c.FirstName.ToLower().Contains(searchTerm) ||
            c.LastName.ToLower().Contains(searchTerm) ||
            c.PhoneNumber.ToLower().Contains(searchTerm) ||
            c.Email.ToLower().Contains(searchTerm)
        ).ToList();
    }

    public void UpdateContact(int contactId, Contact updatedContact)
    {
        Contact existingContact = contacts.FirstOrDefault(c => c.Id == contactId);

        if (existingContact != null)
        {
            existingContact.FirstName = updatedContact.FirstName;
            existingContact.LastName = updatedContact.LastName;
            existingContact.PhoneNumber = updatedContact.PhoneNumber;
            existingContact.Email = updatedContact.Email;
        }
    }

    public void DeleteContact(int contactId)
    {
        Contact contactToDelete = contacts.FirstOrDefault(c => c.Id == contactId);

        if (contactToDelete != null)
        {
            contacts.Remove(contactToDelete);
        }
    }
    public void DisplayAllContacts()
    {
        Console.WriteLine("Все контакты:");

        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}, {contact.PhoneNumber}, {contact.Email}");
        }
    }
}
