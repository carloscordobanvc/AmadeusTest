using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserWebApp.DBModels;

namespace UserWebApp.Services.Users
{
    public class UserService : IUserService
    {
        private readonly App_DBContext _context;
        private readonly IMapper _mapper;
        public UserService(App_DBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task CreateUser(UserDto user)
        {
            var finalUser = _mapper.Map<User>(user);
            _context.Entry(finalUser).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(e => e.UserId == id);
            _context.Entry(user).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserDto>> GetAllUsers()
        {
            var users  = await _context.Users.ToListAsync();
            return _mapper.Map<List<UserDto>>(users);
        }

        public async Task<UserDto> GetUser(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(e => e.UserId == id);
            return _mapper.Map<UserDto>(user);
        }

        public async Task UpdateUser(UserDto user)
        {
            var modifiedUser = _mapper.Map<User>(user);
            _context.Entry(modifiedUser).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
