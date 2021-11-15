using GroceryBuddy.WebAPI.Infrastructure.DAL.EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace GroceryBuddy.WebAPI.Infrastructure.DAL.EntityFramework;

public interface IApplicationDbContext
{
    DbSet<GroceryEntity> Groceries { get; set; }
}
public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<GroceryEntity> Groceries { get; set; } = null!;

    public void EnsureDatabaseIsCreated() => Database.EnsureCreated();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<GroceryEntity>().ToTable("Groceries");
        builder.Entity<GroceryEntity>().HasKey(x => x.Id);
        builder.Entity<GroceryEntity>().Property(x => x.Description).IsRequired().IsUnicode().HasMaxLength(Groceries.DescriptionMaxLength);
    }
}
