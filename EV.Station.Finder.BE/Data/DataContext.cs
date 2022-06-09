using Microsoft.EntityFrameworkCore;

namespace StationAPI.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Station> Stations { get; set; }
}