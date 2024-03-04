using PhoneBook.Crud.Models;

namespace PhoneBook.Crud.Brokers.Storages
{
    internal interface IStorageBroker
    {
        Contact AddContact(Contact contact);
    }
}
