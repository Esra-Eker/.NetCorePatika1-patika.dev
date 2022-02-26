using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PhoneBook App :)");
            //Console.WriteLine("Please select operation");
            Console.WriteLine("********************************************");
            Console.WriteLine("(1) Add contact");
            Console.WriteLine("(2) Display contact by number");
            Console.WriteLine("(3) Wiew all contacts");
            Console.WriteLine("(4) Search for contacts for a given name");
            Console.WriteLine("Press 'x' to exit");

            

            //switch statement ile phonebook objectindeki verilen işlemleri çağıracağız. ama henüz phonebook object imiz yok
            var phoneBook = new PhoneBook();  //phonebook objecti tanımladık.

            while (true) //program tekrar tekrar dönsün diye ekledik.
            {
                Console.WriteLine("Select operation");
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact number: ");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);

                        break;
                    case "2":
                        Console.WriteLine("Contact number to search: ");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);

                        break;
                    case "3":
                        phoneBook.DisplayAllContact();
                        break;
                    case "4":
                        Console.WriteLine("Name search phrase: ");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);

                        break;

                    case "x":
                        return;
                        
                    default:
                        Console.WriteLine("Select valid operation!");
                        break;
                }
                
            }
            
        }

    }
}
