// ConsoleApp/Program.cs
using System;

class Program
{
    static void Main()
    {
        ContactManager contactManager = new ContactManager();

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить контакт");
            Console.WriteLine("2. Найти контакт");
            Console.WriteLine("3. Редактировать контакт");
            Console.WriteLine("4. Удалить контакт");
            Console.WriteLine("5. Просмотреть все контакты");
            Console.WriteLine("6. Выйти");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddContact(contactManager);
                    break;
                case "2":
                    SearchContact(contactManager);
                    break;
                case "3":
                    EditContact(contactManager);
                    break;
                case "4":
                    DeleteContact(contactManager);
                    break;
                case "5":
                    contactManager.DisplayAllContacts();
                    break;
                case "6":
                    // Здесь можно добавить сохранение контактов в файл перед выходом
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                    break;
            }
        }
    }

    static void AddContact(ContactManager contactManager)
    {
        Contact newContact = new Contact();
        Console.WriteLine("Введите имя:");
        newContact.FirstName = Console.ReadLine();

        Console.WriteLine("Введите фамилию:");
        newContact.LastName = Console.ReadLine();

        Console.WriteLine("Введите номер телефона:");
        newContact.PhoneNumber = Console.ReadLine();

        Console.WriteLine("Введите адрес электронной почты:");
        newContact.Email = Console.ReadLine();

        contactManager.AddContact(newContact);
        Console.WriteLine("Контакт успешно добавлен.");
    }

    static void SearchContact(ContactManager contactManager)
    {
        Console.WriteLine("Введите критерии поиска (имя, фамилия, номер телефона или электронная почта):");
        string searchQuery = Console.ReadLine();

        var results = contactManager.SearchContacts(searchQuery);

        if (results.Any())
        {
            Console.WriteLine("Результаты поиска:");
            foreach (var result in results)
            {
                Console.WriteLine($"{result.Id}: {result.FirstName} {result.LastName}, {result.PhoneNumber}, {result.Email}");
            }
        }
        else
        {
            Console.WriteLine("Контакты не найдены.");
        }
    }

    static void EditContact(ContactManager contactManager)
    {
        Console.WriteLine("Введите ID контакта для редактирования:");
        int id = int.Parse(Console.ReadLine());

        Contact contactToEdit = contactManager.Contacts.FirstOrDefault(c => c.Id == id);

        if (contactToEdit != null)
        {
            Contact updatedContact = new Contact();
            Console.WriteLine("Введите новое имя:");
            updatedContact.FirstName = Console.ReadLine();

            Console.WriteLine("Введите новую фамилию:");
            updatedContact.LastName = Console.ReadLine();

            Console.WriteLine("Введите новый номер телефона:");
            updatedContact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Введите новую электронную почту:");
            updatedContact.Email = Console.ReadLine();

            contactManager.UpdateContact(id, updatedContact);
            Console.WriteLine("Контакт успешно отредактирован.");
        }
        else
        {
            Console.WriteLine("Контакт не найден.");
        }
    }

    static void DeleteContact(ContactManager contactManager)
    {
        Console.WriteLine("Введите ID контакта для удаления:");
        int id = int.Parse(Console.ReadLine());

        contactManager.DeleteContact(id);
        Console.WriteLine("Контакт успешно удален.");
    }
}
