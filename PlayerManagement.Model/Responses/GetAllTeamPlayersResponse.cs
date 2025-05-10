namespace PlayerManagement.Model.Responses
{
    public class GetAllTeamPlayersResponse
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Country { get; set; }

        public List<PlayerResponse> Players { get; set; } = new List<PlayerResponse>();
    }
}
