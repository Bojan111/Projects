using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts
{
    class Contact
    {
        
  
        public Person person;

        public List<string> phoneNumbers;

        public Contact(Person persons)
        {
            person = persons;
            phoneNumbers = new List<string>();
        }
        public void AddPhoneNumbers(string _persons)
        {
            phoneNumbers.Add(_persons);
            
        }
        public List<string> GetPhoneNumbers()
        {
            return phoneNumbers;
        }
        public string GetContactName()
        {
            return person.GetFirstName();
        }
    }
}
