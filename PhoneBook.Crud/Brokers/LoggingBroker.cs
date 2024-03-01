﻿using System;

namespace PhoneBook.Crud.Brokers
{
    internal class LoggingBroker : ILoggingBroker
    {
        public void LogInformation(string message) =>
            Console.WriteLine(message);

        public void LogError(Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(exception.Message);
            Console.ResetColor();
        }

    }
}