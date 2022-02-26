using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    //bu class contact listi yönetmekten sorumlu olacak.
    class PhoneBook
    {
        //contact bilgilerini yönetmek için private property e ihtiyacımız var.
        // bu class dışında başka bir yerden değiştirilemesin diye private oluşturuyoruz.
        private List<Contact> _contacts { get; set; } = new List<Contact>(); //_ yaptık çünkü private olduğunu belirtmek istedik.
    
        public void AddContact(Contact contact) //void diyoruz çünkü bu metotta hiçbir şey geriye dönmicek.//bu metot parametre olarak contact object alacak.
        {
            _contacts.Add(contact);
        }
        public void DisplayContact(string number)
        {
            //öncelikle bizim contact listemizden eşleşen contact ları bulmalıyız.
            var contact = _contacts.FirstOrDefault(c => c.Number==number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
            }
            else
            {
                Console.WriteLine("Contact: {0}, {1}", contact.Name, contact.Number);
            }

        }
        public void DisplayAllContact()
        {
            foreach (var contact in _contacts)
            {
                Console.WriteLine("Contact: {0}, {1}", contact.Name, contact.Number);
            }
        }
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            foreach (var contact in matchingContacts)
            {
                Console.WriteLine("Contact: {0}, {1}" , contact.Name, contact.Number);
            }
        }
    }
}
