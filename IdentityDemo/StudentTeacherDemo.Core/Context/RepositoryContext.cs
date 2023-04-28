using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentTeacherDemo.Data.Models;

namespace StudentTeacherDemo.Data.Context;

public class RepositoryContext : IdentityDbContext<User>
{
    public RepositoryContext()
    {

    }
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server = localhost; Database = StudentTeacherDemo; Trusted_Connection = True; TrustServerCertificate = True; MultipleActiveResultSets = True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new TeacherData());
        modelBuilder.ApplyConfiguration(new StudentData());
    }

    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Student> Students { get; set; }
}
