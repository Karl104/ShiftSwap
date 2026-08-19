using ShiftSwap.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace ShiftSwap.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }
    public DbSet<User> Users => Set<User>();
    public DbSet<Shift> Shifts => Set<Shift>();
}
