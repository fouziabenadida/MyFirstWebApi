using DataLayer.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Data;

public class MyFirstWebApiDbContext : DbContext
{
    public MyFirstWebApiDbContext(DbContextOptions<MyFirstWebApiDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Department> Departments { get; set; }
}