using Microsoft.EntityFrameworkCore;

namespace kolokwiumCodeFirst.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}