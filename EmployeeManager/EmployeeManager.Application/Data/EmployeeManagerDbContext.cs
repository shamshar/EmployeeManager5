using EmployeeManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.Application.Data;

public class EmployeeManagerDbContext : DbContext
{
    public EmployeeManagerDbContext(DbContextOptions<EmployeeManagerDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Department> Departments => Set<Department>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Map EF Core entity to your existing table names
        modelBuilder.Entity<Employee>().ToTable("Employees");
        modelBuilder.Entity<Department>().ToTable("Departments"); // if department table is also singular
    }
}
