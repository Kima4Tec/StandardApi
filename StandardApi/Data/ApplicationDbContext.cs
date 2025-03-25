using Microsoft.EntityFrameworkCore;
using StandardApi.Model;

namespace StandardApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Projects> Project { get; set; }
    }
}
