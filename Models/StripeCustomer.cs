using System.Collections.Generic;

namespace StripeCustomers.Models
{
    interface ICustomer 
    {
        string Email {
            get;
            set;
        }
        string Description {
            get;
            set;
        }
        Dictionary<string, string> Metadata {
            get;
            set;
        }
    }

    public class Customer : ICustomer
    {
        public string Email { get; set; }
        public string Description { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
    }
}
