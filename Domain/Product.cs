using System;
using System.Collections.Generic;

namespace Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public ICollection<CategoryProducts> Categories { get; set; } 
        public ICollection<OrderProducts> Orders { get; set; } 
        public ICollection<ProductEvent> Events { get; set; } 
        
    }
}