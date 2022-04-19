using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserWebApp.DBModels
{
    public class App_DBContext : DbContext
    {
        public App_DBContext(DbContextOptions<App_DBContext> options) : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USER");
                entity.Property(e => e.UserId).HasColumnName("USER_ID");
                entity.Property(e => e.FirstName).HasColumnName("FIRST_NAME");
                entity.Property(e => e.SecondName).HasColumnName("SECOND_NAME");
                entity.Property(e => e.FirstSurname).HasColumnName("FIRST_SURNAME");
                entity.Property(e => e.SecondSurname).HasColumnName("SECOND_SURNAME");
                entity.Property(e => e.Cellphone).HasColumnName("CELLPHONE");
                entity.Property(e => e.Birthday).HasColumnName("BIRTHDAY");
                entity.Property(e => e.Email).HasColumnName("EMAIL");
                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
                
            });
        }
    }
}
