using Microsoft.EntityFrameworkCore;
using CrimeHeatmap.API.Models;

namespace CrimeHeatmap.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<CrimeReport> CrimeReports { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
}
