using Microsoft.EntityFrameworkCore;
using TestProjectMoq.Contract;
using TestProjectMoq.Models;

namespace TestProjectMoq.Data;

public class TaskDbContext : DbContext
{
    
    

    public TaskDbContext(DbContextOptions<TaskDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Product> Products { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Apple", Count = 3},
            new Product { Id = 2, Name = "Pencil", Count = 1 }
        );
    }
}