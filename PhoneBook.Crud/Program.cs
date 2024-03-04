using System;
using System.Runtime.CompilerServices;
using PhoneBook.Crud.Models;
using PhoneBook.Crud.Services.Contacts;

namespace PhoneBook.Crud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContactService contactService = new ContactService();

            Contact contact = new Contact
            {
                Id = 1,
                Name = "John Doe",
                Phone = "123-456-7890"
            };

            contactService.AddContact(contact);
        }
    }
}
