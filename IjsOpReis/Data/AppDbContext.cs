using IjsOpReis.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace IjsOpReis.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<IcecreamRecord> IceCreamRecords { get; set; }

    public DbSet<Distance> Distances { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IcecreamRecord>()
            .Property(x => x.Amount)
            .HasPrecision(10, 2);
    }
}
