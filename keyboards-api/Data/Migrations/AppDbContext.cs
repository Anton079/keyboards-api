using keyboards_api.Keyboards.Models;
using Microsoft.EntityFrameworkCore;

namespace keyboards_api.Data.Migrations
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Keyboard> Keyboards { get; set; }
    }
}
