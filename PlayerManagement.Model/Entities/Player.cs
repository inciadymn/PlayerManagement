namespace PlayerManagement.Model.Entities
{
    public class Player : BaseEntity
    {
        public required string FullName { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required int Height { get; set; }
        public required string Position { get; set; }

        public int TeamId { get; set; }
        public Team? Team { get; set; }
    }
}
