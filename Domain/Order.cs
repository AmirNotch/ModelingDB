using System;
using System.Collections.Generic;

namespace Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public int Count { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        public Guid PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
        public ICollection<OrderProducts> Products { get; set; }
        public ICollection<OrderEvent> Events { get; set; }
    }
}