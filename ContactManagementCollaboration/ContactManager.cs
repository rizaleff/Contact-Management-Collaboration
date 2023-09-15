using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementCollaboration
{
    public class ContactManager
    {
        public List<Contact> Contacts { get; private set; }
            

        public ContactManager() 
        { 
            Contacts = new List<Contact>();
        }
        public void CreateContact(string name, string phoneNumber, string emailAddress)
        {
            if (IsValidPhoneNumber(phoneNumber))
            {
                if (IsValidEmailAddress(emailAddress))
                {
                    Contact contact = new Contact(name, phoneNumber, emailAddress);
                    Contacts.Add(contact);
                    
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

        public void SearchContact(string inputSearch)
        {

        }

        public void ViewContact()
        {
            Console.WriteLine("===========Contact List===========");
            foreach (Contact contact in Contacts)
            {
                
                Console.WriteLine($"Nama            : {contact.Name}");
                Console.WriteLine($"Phone Number    : {contact.PhoneNumber}");
                Console.WriteLine($"Email Address   : {contact.EmailAddrress}");
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
