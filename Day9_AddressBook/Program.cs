using static Day9_AddressBook.Address_bookCreate;

namespace Day9_AddressBook
{

    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook newaddressbook = new AddressBook();
            Contact newcontact = new Contact();
           
            Console.WriteLine("Enter Number to Execute the Address book Program \n1. Create contacts \n2. Add contact \n3. Edit contact \n4.Delete contact \n5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact Information first name, last names, address,city, state, zip, phone number and email id");
                        newcontact.firstname = Console.ReadLine();
                        newcontact.lastname = Console.ReadLine();
                        newcontact.address = Console.ReadLine();
                        newcontact.city = Console.ReadLine();
                        newcontact.state = Console.ReadLine();
                        newcontact.zip = Console.ReadLine();
                        newcontact.phonenumber = Console.ReadLine();
                        newcontact.emailid = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information first name, last names, address,city, state, zip, phone number and email id");
                        newcontact.firstname = Console.ReadLine();
                        newcontact.lastname = Console.ReadLine();
                        newcontact.address = Console.ReadLine();
                        newcontact.city = Console.ReadLine();
                        newcontact.state = Console.ReadLine();
                        newcontact.zip = Console.ReadLine();
                        newcontact.phonenumber = Console.ReadLine();
                        newcontact.emailid = Console.ReadLine();
                        newaddressbook.AddContact(newcontact);
                        newaddressbook.Display();
                        break;
                    case 3:
                        newaddressbook.Editexistingcontact();
                        newaddressbook.Display();
                        break;
                    case 4:
                        newaddressbook.Deletecontact();
                        newaddressbook.Display();
                        break;
                    case 5:
                        Console.WriteLine("Exit"); 
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }
    }
    
   
