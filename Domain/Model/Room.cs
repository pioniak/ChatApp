using System.Collections.Generic;

namespace Domain.Model
{
    public class Room
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int CreatorId { get; set; }
        public User Creator { get; set; }
        public ICollection<RoomParticipant> Participants { get; set; }
    }
}
