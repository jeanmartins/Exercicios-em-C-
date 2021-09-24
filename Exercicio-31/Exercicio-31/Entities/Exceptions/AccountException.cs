using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_31.Entities.Exceptions
{
    class AccountException : ApplicationException
    {
    public AccountException(string message): base(message)
        {

        }
    }
}
