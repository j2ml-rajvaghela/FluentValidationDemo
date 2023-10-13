using FluentValidationDemo.API.Configuration;
using FluentValidationDemo.API.Model;
using Microsoft.EntityFrameworkCore;

namespace FluentValidationDemo.API.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }


        // Configure the Model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeModelConfiguration());
        }
    }
}
