namespace PlayerManagement.Model.Responses
{
    public class PlayerResponse
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required string Position { get; set; }
        public int Height { get; set; }
    }
}
