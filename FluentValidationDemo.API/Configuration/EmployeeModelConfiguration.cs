using FluentValidationDemo.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentValidationDemo.API.Configuration
{
    public class EmployeeModelConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("employee_fluentvalidemo");
            builder.HasKey(x => x.EmployeeId);

            builder
                .Property(x => x.EmployeeId)
                .HasColumnName("employee_id")
                .HasColumnType("Bigint")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
              .Property(x => x.EmployeeName)
              .HasColumnName("employee_name")
              .HasColumnType("varchar(30)")
              .IsRequired();

            builder
               .Property(x => x.Age)
               .HasColumnName("age")
               .HasColumnType("int")
               .IsRequired();

            builder
               .Property(x => x.Mobile)
               .HasColumnName("mobile")
               .HasColumnType("varchar(10)")
               .IsRequired();
        }
    }
}
