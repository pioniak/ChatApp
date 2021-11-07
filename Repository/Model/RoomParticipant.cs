using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class RoomParticipant
    {
        public int UserId { get; set; }
        public bool IsAdmin { get; set; }
        public int RoomId { get; set; }
    }
}
