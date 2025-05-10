using AutoMapper;
using PlayerManagement.Model.Entities;
using PlayerManagement.Model.Responses;

namespace PlayerManagement.Model.Mappers
{
    public class TeamMapper : Profile
    {
        public TeamMapper()
        {
            CreateMap<Team, GetAllTeamsResponse>();

            CreateMap<Team, GetAllTeamPlayersResponse>();
        }
    }
}
