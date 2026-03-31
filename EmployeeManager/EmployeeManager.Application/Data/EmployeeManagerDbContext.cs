using EmployeeManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.Application.Data;

public class EmployeeManagerDbContext : DbContext
{
    public EmployeeManagerDbContext(DbContextOptions<EmployeeManagerDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employee => Set<Employee>();
    public DbSet<Department> Department => Set<Department>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Map EF Core entity to your existing table names
        modelBuilder.Entity<Employee>().ToTable("Employee");
        modelBuilder.Entity<Department>().ToTable("Department"); // if department table is also singular
    }
}
