using System.Diagnostics.Contracts;

namespace ContactManagementCollaboration
{
    public class Program
    {


        static void Main(string[] args)
        {
            ContactManager contactManager = new ContactManager();

            while (true)
            {
                Menu.DisplayMainMenu();
                Console.Write("Pilihan : ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Pilihan tidak valid!");
                    continue;
                }

                if (choice == 1)
                {
                    Console.Write("Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Phone Number: ");
                    string phoneNumber = Console.ReadLine();
                    Console.Write("email: ");
                    string emailAddress = Console.ReadLine();
                    contactManager.CreateContact(name, phoneNumber, emailAddress);
                }
                else if (choice == 2)
                {

                    List<Contact> allContact = contactManager.Contacts;
                    int lid = 1;
                    foreach (Contact contact in allContact)
                    {
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine($"ID: {lid}");
                        contact.GetContactData(contact);
                        Console.WriteLine("-----------------------------------------------");
                        lid++;
                    }




                    Menu.DisplayContactMenu();
                    Console.Write("Pilihan : ");
                    int editChoice;
                    if (!int.TryParse(Console.ReadLine(), out editChoice))
                    {
                        Console.WriteLine("Pilihan tidak valid!");
                        continue;
                    }

                    if (editChoice == 1)
                    {
                        Console.Write("Masukkan ID kontak yang ingin diedit: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {

                            if (id > 0 && id <= contactManager.Contacts.Count)
                            {
                                Console.Write("Name : ");
                                string newName = Console.ReadLine();
                                Console.Write("Phone Number : ");
                                string newPhone = Console.ReadLine();
                                Console.Write("Email ");
                                string newEmail = Console.ReadLine();
                                contactManager.UpdateContact(id, newName, newPhone, newEmail);
                            }
                            else
                            {
                                Console.WriteLine("ID kontak tidak valid!");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("ID kontak tidak valid!");
                        }
                    }
                    else if (editChoice == 2)
                    {
                        Console.Write("Masukkan ID kontak yang ingin dihapus: ");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            contactManager.DeleteContact(id);
                           
                            
                        }
                        else
                        {
                            Console.WriteLine("ID kontak tidak valid!");
                        }
                    }
                    else if (editChoice == 3)
                    {
                        Menu.DisplayMainMenu();
                    }
                    else
                    {
                        Console.WriteLine("Pilihan tidak valid!");
                    }
                }


                else if (choice == 3)
                {
                    Console.Write("Masukkan nama pengguna yang ingin Anda cari: ");
                    string searchName = Console.ReadLine();
                    List<Contact> foundContacts = contactManager.SearchContact(searchName);
                    Menu.DisplaySearchResults(foundContacts);
                }


                else if (choice == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid!");
                }
            }
        }
    }
}


