﻿namespace PlayerManagement.Model.Responses
{
    public class GetAllTeamsResponse
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Country { get; set; }
    }
}
