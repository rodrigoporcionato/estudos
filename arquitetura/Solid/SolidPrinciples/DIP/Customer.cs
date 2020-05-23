using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SolidPrinciples.DIP
{
    interface ICustomer {
        void Save();
    }
    interface ILogger {
        void Logger();
    }

    public class Customer : ICustomer
    {
        ILogger log = null;

        public void Save()
        {
            //save customer....

            //write log.
            log.Logger();
        }
    }
}
