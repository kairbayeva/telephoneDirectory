using System;
using PhoneDirectoryLibrary;

namespace PhoneDirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneDirectory = new PhoneDirectory();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Меню Телефонного Справочника:");
                Console.WriteLine("1. Добавить контакт");
                Console.WriteLine("2. Поиск контакта");
                Console.WriteLine("3. Просмотр всех контактов");
                Console.WriteLine("4. Выход");
                Console.Write("Введите ваш выбор: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddContact(phoneDirectory);
                            break;
                        case 2:
                            SearchContact(phoneDirectory);
                            break;
                        case 3:
                            ViewAllContacts(phoneDirectory);
                            break;
                        case 4:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
                }
            }
        }

        static void AddContact(PhoneDirectory phoneDirectory)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите номер телефона: ");
            string phoneNumber = Console.ReadLine();

            phoneDirectory.AddContact(new Contact { Name = name, PhoneNumber = phoneNumber });
            Console.WriteLine("Контакт успешно добавлен!");
        }

        static void SearchContact(PhoneDirectory phoneDirectory)
        {
            Console.Write("Введите имя для поиска: ");
            string searchName = Console.ReadLine();

            Contact foundContact = phoneDirectory.SearchContact(searchName);

            if (foundContact != null)
            {
                Console.WriteLine($"Имя: {foundContact.Name}, Номер телефона: {foundContact.PhoneNumber}");
            }
            else
            {
                Console.WriteLine("Контакт не найден.");
            }
        }

        static void ViewAllContacts(PhoneDirectory phoneDirectory)
        {
            Console.WriteLine("Все контакты в Телефонном Справочнике:");
            var contacts = phoneDirectory.GetAllContacts();

            foreach (var contact in contacts)
            {
                Console.WriteLine($"Имя: {contact.Name}, Номер телефона: {contact.PhoneNumber}");
            }
        }
    }
}
