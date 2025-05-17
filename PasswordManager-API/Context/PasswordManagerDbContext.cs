using Microsoft.EntityFrameworkCore;
using PasswordManager_API.Entities;
using PasswordManager_API.Helpers;

namespace PasswordManager_API.Context
{
    public class PasswordManagerDbContext : DbContext
    {
        public DbSet<LookupType> LookupTypes { get; set; }
        public DbSet<LookupItem> LookupItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public PasswordManagerDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            //LookupType
            modelBuilder.Entity<LookupType>().HasData(
                new LookupType { Id=1,Name= "Nationality" },
                new LookupType { Id = 2, Name = "Role" },
                new LookupType { Id = 3, Name = "UsernameType" },
                new LookupType { Id = 4, Name = "Specialization" },
                new LookupType { Id = 5, Name = "Category" }
                );
            //LookupItem
            modelBuilder.Entity<LookupItem>().HasData(
                new LookupItem { Id = 10, Name = "Jordanian",LookupTypeId = 1 },
                new LookupItem { Id = 1, Name = "Client",LookupTypeId = 2 },
                new LookupItem { Id = 2, Name = "Admin", LookupTypeId = 2 },
                new LookupItem { Id = 3, Name = "Driver", LookupTypeId = 2 },
                new LookupItem { Id = 100, Name = "Phone",LookupTypeId=3 },
                new LookupItem { Id = 101, Name = "Name", LookupTypeId = 3 },
                new LookupItem { Id = 102, Name = "Email", LookupTypeId = 3 },
                new LookupItem { Id = 103, Name = "UserName", LookupTypeId = 3 },
                new LookupItem { Id = 104, Name = "National ID", LookupTypeId = 3 },
                new LookupItem { Id = 200, Name = "Trainer" ,LookupTypeId = 4},
                new LookupItem { Id = 201, Name = "Trainere", LookupTypeId = 4 },
                new LookupItem { Id = 300, Name = "Personal" ,LookupTypeId = 5},
                new LookupItem { Id = 301, Name = "Banking", LookupTypeId = 5 },
                new LookupItem { Id = 302, Name = "Social Media", LookupTypeId = 5 },
                new LookupItem { Id = 303, Name = "Other", LookupTypeId = 5 }
                );
            //User
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1 , 
                    Email = HashingHelper.HashValueWith384("joshaer17@gmail.com"),
                    Password = HashingHelper.HashValueWith384("Z3160@jase"),
                    UserName = HashingHelper.HashValueWith384("joshaer"),
                    RoleId = 2,
                    IsVerfied = true
                }
                );

        }
    }
}
