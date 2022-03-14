using System;
using System.Collections.Generic;

namespace Domain
{
    public class PaymentMethod
    {
        public Guid Id { get; set; }
        public string Method { get; set; }
        public ICollection<Order> Orders { get; set; }
        /*public ICollection<Client> Clients { get; set; }*/
    }
}