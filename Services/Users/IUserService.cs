using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserWebApp.Services.Users
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllUsers(); 
        Task<UserDto> GetUser(int id); 
        Task CreateUser(UserDto user); 
        Task UpdateUser(UserDto user);
        Task DeleteUser(int id);

    }
}
