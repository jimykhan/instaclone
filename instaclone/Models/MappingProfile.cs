using System;
using AutoMapper;
using instaclone.Data.Entities;
using instaclone.Dtos;

namespace instaclone.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserRegisterDto>()
                .ReverseMap();

            CreateMap<ApplicationUser, UserDto>()
                .ForMember(d => d.AppUserId , opt => opt.MapFrom(s => s.Id))
                .ReverseMap();
        }
    }
}
