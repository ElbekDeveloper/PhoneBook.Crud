using PhoneBook.Crud.Models;

namespace PhoneBook.Crud.Services.Contacts
{
    internal interface IContactService
    {
        Contact AddContact(Contact contact);
        void ShowContacts();
    }
}
