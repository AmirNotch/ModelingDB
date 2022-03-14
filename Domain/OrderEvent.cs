using System;

namespace Domain
{
    public class OrderEvent
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string Type { get; set; }
        public string Data { get; set; }
        public int SequenceNumber { get; set; }
    }
}