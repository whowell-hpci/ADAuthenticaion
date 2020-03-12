using ADAuthenticaionAPI.Data;
using ADAuthenticaionAPI.Data.DTOs;
using ADAuthenticaionAPI.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADAuthenticaionAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForReturnDto>();
            CreateMap<UserForRegistrationDto, User>();
            CreateMap<UserForLoginDto, UserForReturnDto>();
        }
    }
}
