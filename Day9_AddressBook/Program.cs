using static Day9_AddressBook.Address_bookCreate;

namespace Day9_AddressBook
{
   
    internal class Program
   {
        static void Main(string[] args) 
        {

            Address_bookCreate addressBook = new Address_bookCreate();
            addressBook.AddContact();
            Console.ReadLine();
        }

    }
    
   
}