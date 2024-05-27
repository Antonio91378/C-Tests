using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace Sparky
{
    public interface ICustomer

    {
        int Discount { get; set; }
        int OrderTotal { get; set; }
        string? GreetMessage { get; set; }
        bool IsPlatinum { get; set; }
        CustomerType GetCustomerDetails();
        string GreetCombineNames(string firstName, string lastName);
    }
    public class Customer : ICustomer

    {
        public int Discount { get; set; }
        public int OrderTotal { get; set; }
        public string? GreetMessage { get; set; }
        public bool IsPlatinum { get; set; }

        public Customer()
        {
            Discount = 15;
            IsPlatinum = false;
        }

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
