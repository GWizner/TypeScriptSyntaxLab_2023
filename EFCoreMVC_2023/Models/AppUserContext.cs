using Microsoft.EntityFrameworkCore;

namespace EFCoreMVC_2023.Models
{
    public class AppUserContext : DbContext
    {
        public AppUserContext(DbContextOptions<AppUserContext> options) : base(options)
        {
        }
        public DbSet<AppUser> AppUsers { get; set; }

    }
}
