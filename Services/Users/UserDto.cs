using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserWebApp.Services.Users
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string FirstSurname { get; set; }
        public string SecondName { get; set; }
        public string SecondSurname { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public int RoleId { get; set; }
    }
}
