using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementSystem.Data.Configurations
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
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
                 Name = "Administrator",
                 NormalizedName = "ADMINISTRATOR",
             }
             );
        }
    }
}
