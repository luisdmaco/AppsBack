using Microsoft.EntityFrameworkCore;
using PCInfo_backend.PCInfo.Domain.Models;

namespace PCInfo_backend.PCInfo.Persistence.Contexts;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<User>().ToTable("users");
        builder.Entity<User>().HasKey(p => p.idUser);
        builder.Entity<User>().Property(p => p.idUser).IsRequired().ValueGeneratedOnAdd();
        
        builder.Entity<Cliente>().ToTable("clientes");
        builder.Entity<Cliente>().HasKey(p => p.idCliente);
        builder.Entity<Cliente>().Property(p => p.idCliente).IsRequired().ValueGeneratedOnAdd();
        
        //Relationships
        builder.Entity<Cliente>()
            .HasOne(p => p.user)
            .WithOne()
            .HasForeignKey<Cliente>(c => c.idUser);
    }
}