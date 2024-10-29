using Microsoft.EntityFrameworkCore;
using BackendAPI3.Models;

namespace BackendAPI3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<AppDocument> Documents { get; set; }
    }
}
