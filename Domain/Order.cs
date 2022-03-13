using System;
using System.Collections.Generic;

namespace Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public int Count { get; set; }
        //public string ClientId { get; set; }
        public Client Client { get; set; }
        //public string PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string AddressId { get; set; }
        //public Address Address { get; set; }
        public ICollection<OrderProducts> Products { get; set; }
    }
}