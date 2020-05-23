using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.OCP
{
    public class Customer
    {
        public int InvoiceNumber { get; set; }
    }

    public class CustomerNew : Customer {
        
        public new string InvoiceNumber { get; set; }
    }
}
