using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MVC_03.DAL.Context.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(d => d.Id)
                .UseIdentityColumn(10, 10);

            builder.Property(d => d.Name)
                .HasMaxLength(50)
                .IsRequired(true)
                .HasColumnType("NVarChar");

            builder.Property(d => d.Code)
                .HasMaxLength(50)
                .IsRequired(true)
                .HasColumnType("NVarChar");

            builder.Property(d => d.Description)
                .HasMaxLength(50)
                .HasColumnType("NVarChar");

            builder.Property(d => d.CreatedOn)
                .HasDefaultValueSql("GetDate()");
        }
    }
}
