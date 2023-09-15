using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementCollaboration
{
    public class ContactManager
    {
        private List<Contact> contacts = new List<Contact>();

        public void CreateContact(string name, string phoneNumber, string emailAddress)
        {
            if (IsValidPhoneNumber(phoneNumber))
            {
                if (IsValidEmailAddress(emailAddress))
                {
                    Contact contact = new Contact(name, phoneNumber, emailAddress); 
                }
                else
                {
                    Console.WriteLine("Email Address Tidak Valid!");
                }
            }
            else
            {
                Console.WriteLine("Phone Number Tidak Valid!");
            }
        }

        private bool IsValidEmailAddress(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }
    }
}
