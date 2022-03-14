using System;
using System.Collections.Generic;

namespace Domain
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
        /*public ICollection<Client> Clients { get; set; }*/
    }
}