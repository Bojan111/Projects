using System;
using System.Collections.Generic;

namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of people:");
            var count = int.Parse(Console.ReadLine());
            PhoneBook phonenumbers = new PhoneBook();

            var contactname = new List<Person>();
            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter number {i + 1} people: ");

                Console.Write("Enter FirstName: ");
                var name = Console.ReadLine();
                Console.Write("Enter LastName: ");
                var lastname = Console.ReadLine();

                var personcontact = new Person();
                personcontact.AddName(name,lastname);

                Contact contact = new Contact(personcontact);

                Console.WriteLine("Enter number of phonenumber: ");
                var countContact = int.Parse(Console.ReadLine());
                for (int j = 0; j < countContact; j++)
                {
                    Console.WriteLine($"Enter {j} phonenumbers");
                    var accounts = Console.ReadLine();
                    contact.AddPhoneNumbers(accounts);
                }
                phonenumbers.AddContact(contact);

                
            }
            while (true)
            {
                Console.WriteLine("Find contact by name of person For quit enter 'q'");
                var personContact = Console.ReadLine();
                if(personContact == "q")
                {
                    Console.WriteLine("Bye");
                    break;
                }

                var contactsPersons = phonenumbers.GetPhoneNumber(personContact);
                if (contactsPersons == null)
                {
                    Console.WriteLine("Not found");
                }
                else
                {
                    Console.WriteLine($"Found {contactsPersons.Count} phonenumbers");
                    foreach (var item in contactsPersons)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
