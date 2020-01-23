using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
   public class Writer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public void AddName(string name,string lastname)
        {
            Name = name;
            LastName = lastname;
        }
        public string GetFirstName()
        {
            return Name.ToString();
        }
    }
}
