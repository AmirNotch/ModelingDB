using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryProducts> Products { get; set; }
    }
}