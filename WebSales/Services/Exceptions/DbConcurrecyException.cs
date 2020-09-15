using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSales.Services.Exceptions
{
    public class DbConcurrecyException : ApplicationException
    {
        public DbConcurrecyException(string message) : base(message)
        {

        }
    }
}
