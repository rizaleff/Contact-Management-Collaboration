using System;
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
            Console.WriteLine("4. Exit");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
        }
    }
}
