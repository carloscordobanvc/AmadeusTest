using AutoMapper;
using UserWebApp.DBModels;

namespace UserWebApp.Services.Users
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
