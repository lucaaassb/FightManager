using FightManager.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FightManager.Infrastructure.Persistence;

public class FightManagerDbContext : DbContext
{
    public FightManagerDbContext(DbContextOptions<FightManagerDbContext> options) : base(options)
    {
        
    }

    public DbSet<Classroom> Classrooms { get; set; }
    public DbSet<Frequency> Frequencies { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Plan> Plans { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}