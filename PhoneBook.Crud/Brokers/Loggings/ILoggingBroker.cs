using System;

namespace PhoneBook.Crud.Brokers.Loggings
{
    internal interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogError(Exception exception);
    }
}
