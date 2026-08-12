using CrmApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrmApi.Data;

public class CrmDbContext : DbContext
{
    public CrmDbContext(DbContextOptions<CrmDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
    public DbSet<Company> Companies => Set<Company>();
    public DbSet<Contact> Contacts => Set<Contact>();
    public DbSet<Deal> Deals => Set<Deal>();
    public DbSet<Activity> Activities => Set<Activity>();

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<User>(e => { e.HasIndex(u => u.Email).IsUnique(); });

        mb.Entity<Contact>(e =>
        {
            e.HasOne(c => c.Company).WithMany(co => co.Contacts)
             .HasForeignKey(c => c.CompanyId).OnDelete(DeleteBehavior.SetNull);
        });

        mb.Entity<Deal>(e =>
        {
            e.Property(d => d.Value).HasColumnType("decimal(18,2)");
            e.Property(d => d.Stage).HasConversion<string>();
            e.HasOne(d => d.Contact).WithMany(c => c.Deals)
             .HasForeignKey(d => d.ContactId).OnDelete(DeleteBehavior.SetNull);
            e.HasOne(d => d.Company).WithMany(c => c.Deals)
             .HasForeignKey(d => d.CompanyId).OnDelete(DeleteBehavior.SetNull);
        });

        mb.Entity<Activity>(e =>
        {
            e.Property(a => a.Type).HasConversion<string>();
            e.HasOne(a => a.Contact).WithMany(c => c.Activities)
             .HasForeignKey(a => a.ContactId).OnDelete(DeleteBehavior.SetNull);
            e.HasOne(a => a.Deal).WithMany(d => d.Activities)
             .HasForeignKey(a => a.DealId).OnDelete(DeleteBehavior.SetNull);
            e.HasOne(a => a.User).WithMany(u => u.Activities)
             .HasForeignKey(a => a.UserId).OnDelete(DeleteBehavior.Cascade);
        });
    }
}
