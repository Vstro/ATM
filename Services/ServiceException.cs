using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services
{
    class ServiceException : Exception
    {
        public ServiceException() : base() {}
        public ServiceException(String message) : base(message) {}
    }
}
