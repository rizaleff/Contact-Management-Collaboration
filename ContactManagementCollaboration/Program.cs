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
                    int id = 1;
                    foreach (Contact contact in allContact)
                    {
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine($"ID: {id}");
                        Console.WriteLine($"Name: {contact.Name}");
                        Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
                        Console.WriteLine($"Email Address: {contact.EmailAddrress}");
                        Console.WriteLine("-----------------------------------------------");
                        id++;
                    } }

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
                    Console.Write("Masukkan ID pengguna yang ingin diedit: ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        /* Contact contactToEdit = contactManager.GetContactById(id);*/
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
                            Console.WriteLine("ID pengguna tidak valid!");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("ID pengguna tidak valid!");
                    }
                }
                else if (editChoice == 2)
                {
                    Console.Write("Masukkan ID pengguna yang ingin dihapus: ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        contactManager.DeleteContact(id);
                    }
                    else
                    {
                        Console.WriteLine("ID pengguna tidak valid!");
                    }
                }
                else if (editChoice == 3)
                {
                    Menu.DisplayMainMenu();
                }
              
            
            else if (choice == 3)
            {
                Console.Write("Masukkan nama pengguna yang ingin Anda cari: ");
                string searchName = Console.ReadLine();
                List<User> foundUsers = userManager.GetUsers().Where(user =>
                    user.FirstName.Contains(searchName, StringComparison.OrdinalIgnoreCase) ||
                    user.LastName.Contains(searchName, StringComparison.OrdinalIgnoreCase)
                ).ToList();

                Menu.DisplaySearchResults(foundUsers);
            }
            else if (choice == 4)
            {
                Console.Write("Username: ");
                string lUsername = Console.ReadLine();
                Console.Write("Password: ");
                string lPassword = Console.ReadLine();

                User loggedInUser = userManager.GetUsers().FirstOrDefault(user =>
                    user.UserName.Equals(lUsername, StringComparison.OrdinalIgnoreCase) &&
                    user.Password.Equals(lPassword)
                );

                if (loggedInUser != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Login Sebagai : " + lUsername);
                    Console.WriteLine();
                    while (true)
                    {
                        Menu.DisplayUserMenu();
                        Console.Write("Pilihan : ");
                        int userChoice;
                        if (!int.TryParse(Console.ReadLine(), out userChoice))
                        {
                            Console.WriteLine("Pilihan tidak valid!");
                            continue;
                        }

                        if (userChoice == 1)
                        {
                            Console.Write("Masukkan Bilangan yang ingin di cek : ");
                            int num;
                            if (!int.TryParse(Console.ReadLine(), out num))
                            {
                                Console.WriteLine("Input tidak valid!");
                                continue;
                            }

                            string result = GanjilGenap.EvenOddCheck(num);
                            Console.WriteLine(result);
                        }
                        else if (userChoice == 2)
                        {
                            Console.Write("Pilih (Ganjil/Genap) : ");
                            string choice2 = Console.ReadLine();
                            Console.Write("Masukkan limit : ");
                            int limit;
                            if (!int.TryParse(Console.ReadLine(), out limit))
                            {
                                Console.WriteLine("Limit tidak valid!");
                                continue;
                            }

                            if (choice2 != "Genap" && choice2 != "Ganjil")
                            {
                                Console.WriteLine("Input pilihan tidak valid!!!");
                                continue;
                            }

                            GanjilGenap.PrintEvenOdd(limit, choice2);
                        }
                        else if (userChoice == 3)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Pilihan tidak valid!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Login gagal. Username atau password salah.");
                }
            }
            else if (choice == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid!");
            }
        }
    } }
        }
    } 

