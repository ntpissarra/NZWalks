using AutoMapper;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Models.Profiles;

public class RegionsProfiles : Profile
{
    public RegionsProfiles()
    {
        CreateMap<Region, DTO.Region>()
            .ReverseMap();
    }
}