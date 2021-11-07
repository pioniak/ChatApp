namespace Domain.Model
{
    public class RoomParticipant
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsAdmin { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public User User { get; set; }
    }
}
