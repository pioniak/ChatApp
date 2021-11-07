using System;

namespace Domain.Model
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime SendTimestamp { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int SenderId { get; set; }
        public User Sender { get; set; }
    }
}
