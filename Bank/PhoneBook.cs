using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    class PhoneBook
    {
        private List<Contact> _contacts { get; set; }= new List<Contact>(); 
        
        
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine("Contact:{0}\n {1}", contact.Name, contact.Number);
        }
        public void AddContact(Contact contact)
        {

            if (contact.Number.Length == 10)
            {
                _contacts.Add(contact);
                Console.WriteLine("Contact Added");
            }
            else
            {
                Console.WriteLine("Enter Valid Phone Number");
            }


        }

        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);//lambda exp
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }

        }

        public void DisplayAllContact()
        {
            foreach (var contact in _contacts)
            {
                DisplayContactDetails(contact);
            }
        }
        
        public void DisplayMatchingContact(string searchPhrase)
        {
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            foreach(var contact in matchingContacts)
            {
                DisplayContactDetails(contact);
            }
        
        }

    }
}
