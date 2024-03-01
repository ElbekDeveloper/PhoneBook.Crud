using System;

namespace PhoneBook.Crud.Brokers
{
    internal interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogError(Exception exception);
    }
}
