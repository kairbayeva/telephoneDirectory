using System;

namespace PhoneDirectoryLibrary
{
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class PhoneDirectory
    {
        private List<Contact> contacts = new List<Contact>();

        // Метод для добавления нового контакта
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        // Метод для поиска контакта по имени
        public Contact SearchContact(string name)
        {
            return contacts.Find(contact => contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // Метод для получения списка всех контактов
        public List<Contact> GetAllContacts()
        {
            return contacts;
        }
    }
}
