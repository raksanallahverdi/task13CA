using System;
using Microsoft.VisualBasic;

namespace Task2
{
	public class PhoneBook
	{
		public Dictionary<string,string> Contacts { get; set; }


		public PhoneBook()
		{
			Contacts = new Dictionary<string,string>();
		}

		public void AddContact(string name,string number)
		{

			Contacts.Add(name, number);
			
		}
		public void RemoveContact(string name)
		{
			Contacts.Remove(name);
		}
		public void GetAllContacts()
		{
            foreach(var contact in Contacts)
			{
				Console.WriteLine($"{contact.Key},{contact.Value}");
			}
        }

		public void FindContactByName(string name)
		{
			foreach(var contact in Contacts)
			{
				if (contact.Key == name)
				{
                    Console.WriteLine($"{contact.Key},{contact.Value}");
					return;
                }

			}
			Console.WriteLine("bele adam yoxdur");
		}
	}
}

