using Microsoft.EntityFrameworkCore;
using VehicleFleetManagement.Extensions;
using VehicleFleetManagement.Models;
namespace VehicleFleetManagement.Data;
public class DataContext : DbContext
{
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Brand> Brands { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Model>().GenerateData();
        modelBuilder.Entity<Brand>().GenerateData();
        modelBuilder.Entity<Vehicle>().GenerateData();
    }
}

