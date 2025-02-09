using Microsoft.EntityFrameworkCore;

namespace DemoBlazorServerAuthWithGoogle.Authentication;

public class AppDbContext : DbContext
{
    public DbSet<AppUser> GoogleUsers { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options: options)
    {
        
    }
}
