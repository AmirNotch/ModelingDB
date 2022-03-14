using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain
{
    public class Client
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Order> Orders { get; set; }
        /*public Guid PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }*/
    }
}