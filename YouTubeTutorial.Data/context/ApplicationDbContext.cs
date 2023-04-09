using Microsoft.EntityFrameworkCore;
using System.Net;

namespace YouTubeTutorial.Data.context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<student> student { get; set; }
        public DbSet<addresses> addresses { get; set; }
        public DbSet<vehicle> vehicle { get; set; }
    }
}
