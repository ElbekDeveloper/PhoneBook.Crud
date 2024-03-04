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

            contactService.AddContact(new Contact());
        }
    }
}
