
namespace Task2
{
    public static class Program
    {
        public static void Main()
        {
            PhoneBook addressBook = new PhoneBook();
            addressBook.AddContact("Raksana", "0555555");
            addressBook.AddContact("Chinara", "9443838");
            addressBook.AddContact("Khadija", "0778849");
            addressBook.RemoveContact("Chinara");
            addressBook.GetAllContacts();
           
            addressBook.FindContactByName("Raksana");
            Console.ReadLine();

        }
    }
}

