using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace Sparky
{
    public class Customer

    { 
        public int Discount { get; set; } = 15;
        public int OrderTotal { get; set; }
        public string? GreetMessage { get; set; }
        public string GreetCombineNames(string firstName, string lastName)
        {
            if (firstName.IsNullOrEmpty())
            {
                throw new ArgumentException("First Name empty");
            }
            this.GreetMessage = "Hello, " + firstName + " " + lastName;
            this.Discount = 20;
            return this.GreetMessage;
        }

        public CustomerType GetCustomerDetails()
        {
            if (OrderTotal < 100)
            {
                return new BasicCustomer();
            }
            return new PlatinumCustomer();
        }
    }

    public class CustomerType { }
    public class BasicCustomer : CustomerType { }
    public class PlatinumCustomer : CustomerType { }
}
