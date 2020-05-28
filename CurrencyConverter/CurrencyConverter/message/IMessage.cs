using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyConverter.message
{
    public interface IMessage
    {
        void Longtime(string message);
        void Shorttime(string message);
    }
}
