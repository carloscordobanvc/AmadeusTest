using System;
using System.Collections.Generic;
using System.Text;
using UserWebApp.DBModels;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using UserWebApp.Services.Users;

namespace UserWebAppTest.Config
{
    public static class ApplicationDbContextInMemory
    {
        public static App_DBContext Get()
        {
            var options = new DbContextOptionsBuilder<App_DBContext>().UseInMemoryDatabase(databaseName: "TestDb").Options;
            return new App_DBContext(options);
        }
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(options =>
            {
                options.AddProfile(new UserProfile());
            });
            return config.CreateMapper();
        }
    }
}
