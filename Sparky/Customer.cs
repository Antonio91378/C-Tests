using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class Customer
    {
        public string? GreetMessage { get; set; }
        public string GreetCombineNames(string firstName, string lastName)
        {
            this.GreetMessage = "Hello, " + firstName + " " + lastName;
            return this.GreetMessage;
        }
    }
}
