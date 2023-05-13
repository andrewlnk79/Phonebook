using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class Contact
    {
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }

       
        

        public Contact(string surname, string phoneNumber )
        {
            SurName = surname;
            PhoneNumber = phoneNumber;
            
        }
    }
}
