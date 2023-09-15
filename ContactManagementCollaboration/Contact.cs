using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementCollaboration
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddrress { get; set; }

        public Contact (string name, string phoneNumber, string emailAddress) 
        { 
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddrress = emailAddress;

        }
    }
}
