using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts
{
    class PhoneBook
    {
        public List<Contact> contactName;

        public PhoneBook()
        {
            contactName = new List<Contact>();
        }
        public void AddContact(Contact _contact)
        {
            contactName.Add(_contact);
        }
        public List<string> GetPhoneNumber(string name)
        {
            List<string> listofcontacts = new List<string>();
            for (int i = 0; i < contactName.Count; i++)
            {
                if (contactName[i].person.GetFirstName() == name)
                {
                    listofcontacts = contactName[i].GetPhoneNumbers();
                }
            }
            return listofcontacts;
        }
    }
}
