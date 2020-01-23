using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

       
        public void AddName(string name, string lastname)
        {
            FirstName = name;
            LastName = lastname;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
    }
}
