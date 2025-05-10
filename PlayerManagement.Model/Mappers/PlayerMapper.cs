using AutoMapper;
using PlayerManagement.Model.Entities;
using PlayerManagement.Model.Requests;
using PlayerManagement.Model.Responses;

namespace PlayerManagement.Model.Mappers
{
    public class PlayerMapper : Profile
    {
        public PlayerMapper()
        {
            CreateMap<Player, GetPlayerByIdResponse>().AfterMap((src, dest) =>
            {
                dest.Age = (DateTime.Now.Year - src.DateOfBirth.Year);
                dest.TeamName = src.Team?.Name;
                dest.TeamId = src.Team?.Id;
            });

            CreateMap<Player, CreatePlayerResponse>().AfterMap((src, dest) =>
            {
                dest.Age = (DateTime.Now.Year - src.DateOfBirth.Year);
            });

            CreateMap<CreatePlayerRequest, Player>();

            CreateMap<UpdatePlayerRequest, Player>();

            CreateMap<Player, PlayerResponse>().AfterMap((src, dest) =>
            {
                dest.Age = (DateTime.Now.Year - src.DateOfBirth.Year);
            });
        }
    }
}
