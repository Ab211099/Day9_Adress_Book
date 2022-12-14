using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_AddressBook
{
    internal class AddressBook
    {
        List<Contact> AddressList = new List<Contact>();
        public void AddContact(Contact newcontact)
        {
            AddressList.Add(newcontact);
        }
        public void Editexistingcontact()
        {
            Console.WriteLine("Enter first name of person you want to edit");
            string name = Console.ReadLine();
            foreach (var contact in AddressList)
            {
                if (contact.firstname == name)
                {
                    Console.WriteLine("Enter number : \n 1. First name \n 2. Last name \n 3. Address \n 4. City \n 5. State \n 6. Zip code \n 7. Phone Number \n 8. Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter new firstname");
                            string first = Console.ReadLine();
                            contact.firstname = first;
                            break;
                        case 2:
                            Console.WriteLine("Enter new lastname");
                            string last = Console.ReadLine();
                            contact.lastname = last;
                            break;
                        case 3:
                            Console.WriteLine("Enter new address");
                            string address = Console.ReadLine();
                            contact.address = address;
                            break;
                        case 4:
                            Console.WriteLine("Enter new city");
                            string city = Console.ReadLine();
                            contact.city = city;
                            break;
                        case 5:
                            Console.WriteLine("Enter new state");
                            string state = Console.ReadLine();
                            contact.state = state;
                            break;
                        case 6:
                            Console.WriteLine("Enter new zip");
                            string zip = Console.ReadLine();
                            contact.zip = zip;
                            break;
                        case 7:
                            Console.WriteLine("Enter new phonenumber");
                            string phone = Console.ReadLine();
                            contact.phonenumber = phone;
                            break;
                        case 8:
                            Console.WriteLine("Enter new emailid");
                            string email = Console.ReadLine();
                            contact.emailid = email;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public void Deletecontact()
        {
            Console.WriteLine("Enter first name you want delete");
            string name = Console.ReadLine();
            Contact delete = new Contact();
            foreach (var contact in AddressList)
            {
                if (contact.firstname == name)
                {
                    AddressList.Remove(contact);
                    Console.WriteLine(name + " contact is deleted");
                    Display();
                    break;
                }
            }
        }
        public void Display()
        {
            foreach (var contact in AddressList)
            {
                Console.WriteLine("\nfirstname: " + contact.firstname + "\nlastname: " + contact.lastname + "\naddress: " + contact.address + "\ncity: " + contact.city + "\nstate: " + contact.state + "\nzip: " + contact.zip + "\nphoneno: " + contact.phonenumber + "\nemail: " + contact.emailid);
            }
        }
    }
}
