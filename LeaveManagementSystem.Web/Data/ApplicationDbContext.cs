using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole 
                {
                    Id = "9810262d-f38d-4222-bcdb-2ef3957832b8",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                }, 
                new IdentityRole 
                {
                    Id = "61707094-6be6-439a-b635-a13edefea6ac",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR",
                }, 
                new IdentityRole 
                {
                    Id = "57244434-5457-4c86-a6ba-079b397da049",
                    Name = "Adminstrator",
                    NormalizedName = "ADMINSTRATOR",
                }
                );

            var hasher = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "fe6e6408-cc97-419b-9060-4d483149b4a2",
                Email = "admin@localdbhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                PasswordHash = hasher.HashPassword(null, "Kuttar47**"),
                EmailConfirmed = true,
                FirstName = "Deafult",
                LastName = "Admin",
                DateOfBirth = new DateOnly(1950, 12, 01)
            });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "57244434-5457-4c86-a6ba-079b397da049",
                    UserId = "fe6e6408-cc97-419b-9060-4d483149b4a2"
                }
                );
        }

        public DbSet <LeaveType> LeaveTypes { get; set; }
    }
}
