using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Room
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public User Creator { get; set; }
        public ICollection<RoomParticipant> Participants { get; set; }
    }
}
