using System;

namespace Domain
{
    public class ProductEvent
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string Type { get; set; }
        public string Data { get; set; }
        public int SequenceNumber { get; set; }
    }
}