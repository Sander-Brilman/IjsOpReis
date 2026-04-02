using IJsOpReis.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IJsOpReis.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<IcecreamRecord> IceCreamRecords { get; set; }

    public DbSet<Distance> Distances { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IcecreamRecord>()
            .Property(x => x.Amount)
            .HasPrecision(10, 2);
            
        // Force all DateTime properties to be treated as UTC
        foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
        foreach (IMutableProperty property in entityType.GetProperties())
        {
            if (property.ClrType != typeof(DateTime)) { continue; }

            property.SetValueConverter(new ValueConverter<DateTime, DateTime>(
                v => v.Kind == DateTimeKind.Unspecified ? DateTime.SpecifyKind(v, DateTimeKind.Utc) : v,
                v => v.ToUniversalTime()
            ));
        }
    }
}
