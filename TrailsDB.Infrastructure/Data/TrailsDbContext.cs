using Microsoft.EntityFrameworkCore;
using TrailsDB.Core.Models;
public class TrailsDbContext : DbContext
{
    public TrailsDbContext(DbContextOptions<TrailsDbContext> options) : base(options)
    {
    }

    public DbSet<Walk> Walks { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Review> Reviews { get; set; }
}