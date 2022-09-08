

namespace Day9_AddressBook
{
   
    internal class Program
   {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.Write("Enter First Name, Last Name, Address, City, State, Zip, Phone Number, Email \n");
            Contact addressBook = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToDouble(Console.ReadLine()),
                PhoneNumber = Convert.ToDouble(Console.ReadLine()),
                Email = Console.ReadLine(),
            };
            addressBook.displayContact();
            Console.ReadLine();
        }
        

    }
    
   
}