﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementCollaboration
{
    public class Menu
    {
        public static void DisplayMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("===============================================");
            Console.WriteLine("               Contact Management");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1. Create Contact");
            Console.WriteLine("2. Show Contact");
            Console.WriteLine("3. Search Contact");
            Console.WriteLine("4. Exit");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
        }

        public static void DisplayContactMenu()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1. Edit Contact");
            Console.WriteLine("2. Delete Contact");
            Console.WriteLine("3. Exit");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
        }

        public static void DisplaySearchResults(List<Contact> foundContacts)
        {
            if (foundContacts.Count > 0)
            {
                Console.WriteLine("Hasil Pencarian:");
                foreach (var contact in foundContacts)
                {
                    Console.WriteLine($"Name            : {contact.Name}");
                    Console.WriteLine($"Phone Number    : {contact.PhoneNumber}");
                    Console.WriteLine($"Email Address   : {contact.EmailAddrress}");
                    Console.WriteLine("-----------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Pengguna tidak ditemukan.");
            }
        }
    }
}
