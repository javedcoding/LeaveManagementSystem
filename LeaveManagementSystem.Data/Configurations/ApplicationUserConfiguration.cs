using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                new ApplicationUser{
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
        }
    }
}
