using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using System.Threading.Tasks;
using UserWebApp.DBModels;
using UserWebApp.Services.Users;
using UserWebAppTest.Config;

namespace UserWebAppTest
{
    [TestClass]
    public class UserServiceTest
    {

        [TestMethod]
        public async Task TryToGetAllUsers()
        {
            var context = ApplicationDbContextInMemory.Get();
            var mapper = ApplicationDbContextInMemory.GetMapper();
            context.Add(new User()
            {
                FirstName = "Carlos",
                FirstSurname = "Cordoba",
                Email = "carlosm.cordobae@gmail.com",
                Cellphone = "3013214435",
                RoleId = 1
            });
            context.SaveChanges();
            var context2 = ApplicationDbContextInMemory.Get();
            var userService = new UserService(context2, mapper);
            var response = await userService.GetAllUsers();
            Assert.AreEqual(1, response.Count());
        }
        [TestMethod]
        public async Task TryToCreateUser()
        {
            var context = ApplicationDbContextInMemory.Get();
            var mapper = ApplicationDbContextInMemory.GetMapper();
            var user =  new UserDto()
            {
                FirstName = "Carlos",
                FirstSurname = "Cordoba",
                Email = "carlosm.cordobae@gmail.com",
                Cellphone = "3013214435",
                RoleId = 1
            };
            context.SaveChanges();
            var context2 = ApplicationDbContextInMemory.Get();
            var userService = new UserService(context2, mapper);
            await userService.CreateUser(user);
            var response = await context.Users.ToArrayAsync();
            Assert.AreEqual(1, response.Count());
        }
        [TestMethod]
        public async Task TryToRemoveUser()
        {
            var context = ApplicationDbContextInMemory.Get();
            var mapper = ApplicationDbContextInMemory.GetMapper();
            var user = new User()
            {
                FirstName = "Carlos",
                FirstSurname = "Cordoba",
                Email = "carlosm.cordobae@gmail.com",
                Cellphone = "3013214435",
                RoleId = 1
            };
            context.Add(user);
            context.SaveChanges();
            var userId = user.UserId;

            var context2 = ApplicationDbContextInMemory.Get();
            var userService = new UserService(context2, mapper);
            await userService.DeleteUser(userId);

            var response = await context.Users.ToArrayAsync();
            Assert.AreEqual(0, response.Count());
        }
        [TestMethod]
        public async Task TryToModifyUser()
        {
            var context = ApplicationDbContextInMemory.Get();
            var mapper = ApplicationDbContextInMemory.GetMapper();
            var user = new User()
            {
                FirstName = "Carlos",
                FirstSurname = "Cordoba",
                Email = "carlosm.cordobae@gmail.com",
                Cellphone = "3013214435",
                RoleId = 1
            };
            context.Add(user);
            context.SaveChanges();
            var userId = user.UserId;
            var user2 = new UserDto()
            {   
                UserId = userId,
                FirstName = "Mauro",
                FirstSurname = "Cordoba",
                Email = "carlosm.cordobae@gmail.com",
                Cellphone = "3013214435",
                RoleId = 1
            };
            var context2 = ApplicationDbContextInMemory.Get();
            var userService = new UserService(context2, mapper);
            await userService.UpdateUser(user2);
            var finalUser = await context2.Users.FirstOrDefaultAsync();
            Assert.AreEqual(finalUser.FirstName, user2.FirstName);
        }
    }
}
