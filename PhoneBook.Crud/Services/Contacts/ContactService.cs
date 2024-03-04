using PhoneBook.Crud.Brokers.Loggings;
using PhoneBook.Crud.Brokers.Storages;
using PhoneBook.Crud.Models;

namespace PhoneBook.Crud.Services.Contacts
{
    internal class ContactService : IContactService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public ContactService()
        {
            this.storageBroker = new FileStorageBroker();
            this.loggingBroker = new LoggingBroker();
        }
        
        public Contact AddContact(Contact contact) =>
            this.storageBroker.AddContact(contact);
    }
}
