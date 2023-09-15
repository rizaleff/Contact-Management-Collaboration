using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementCollaboration
{
    internal class ContactManager
    {
        public List<Contact> Contacts { get; private set; }
        public Stack<Contact> DeletedContacts { get; private set; }

        public ContactManager()
        {
            Contacts = new List<Contact>();
            Contacts.Add(new Contact("Rizal", "0812312123", "rizal@gmail.com"));
            Contacts.Add(new Contact("Nanda", "0814566121", "nanda@gmail.com"));
        }
        public void CreateContact(string name, string phoneNumber, string emailAddress)
        {
            if (phoneNumber.Length >= 3)
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
            bool isExists = (Contacts.Any(x => x.Name.Contains(inputSearch, StringComparison.OrdinalIgnoreCase))
                        || Contacts.Any(x => x.PhoneNumber.Contains(inputSearch, StringComparison.OrdinalIgnoreCase))
                        || Contacts.Any(x => x.EmailAddrress.Contains(inputSearch, StringComparison.OrdinalIgnoreCase)));
            /*Console.Write("Masukkan nama pengguna yang ingin Anda cari: ");
            string searchName = Console.ReadLine();
            List<User> foundUsers = userManager.GetUsers().Where(user =>
                user.FirstName.Contains(searchName, StringComparison.OrdinalIgnoreCase) ||
                user.LastName.Contains(searchName, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            Menu.DisplaySearchResults(foundUsers);*/


        }

        public void DeleteContact(int id)
        {
            if (id < Contacts.Count)
            {
                DeletedContacts.Push(Contacts[id - 1]);
                Contacts.RemoveAt(id - 1);
                Console.WriteLine("Data Berhasil Dihapus");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Id kontak tidak ditemukan!");
            }
        }

        public void UpdateContact(int id, string name, string phoneNumber, string emailAddress)
        {
            if(id < Contacts.Count)
            {
                if (phoneNumber.Length >= 3)
                {
                    if (IsValidEmailAddress(emailAddress))
                    {
                        Contacts[id-1].Name = name;
                        Contacts[id - 1].PhoneNumber = phoneNumber;
                        Contacts[id - 1].EmailAddrress = emailAddress;
                    }
                    else
                    {
                        Console.WriteLine("Format Email Address Tidak Valid!");
                    }
                }
                else
                {
                    Console.WriteLine("Phone Number Tidak Valid!");
                }
            }
            else
            {
                Console.WriteLine("Id Kontak Tidak Ditemukan!");
            }
        }

        public Contact GetUserById(int id)
        {
            
        }
        private bool IsValidEmailAddress(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }
    }
}
