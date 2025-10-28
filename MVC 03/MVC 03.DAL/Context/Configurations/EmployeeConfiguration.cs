using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVC_03.DAL.Entities.Enums;

namespace MVC_03.DAL.Context.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Id)
                .UseIdentityColumn(10, 10);
            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired(true);

                  builder.Property(e => e.Image)
                .HasMaxLength(50)
                .IsRequired(false)

                .HasColumnType("NVarChar");
            builder.Property(e => e.Age)
                .IsRequired(false);
            builder.Property(e => e.Email)
                .HasMaxLength(50)
                .IsRequired(true)
                .HasColumnType("NVarChar");
            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsRequired(true)
                .HasColumnType("NVarChar");
            builder.Property(e => e.HireDate)
                .IsRequired(true);
            builder.Property(e => e.Gender)
                .HasConversion(x => x.ToString(), s => Enum.Parse<Gender>(s));
            builder.Property(e => e.EmployeeType)
                .HasConversion(x => x.ToString(), s => Enum.Parse<EmployeeType>(s));
        }
    }
}
