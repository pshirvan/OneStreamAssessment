using Microsoft.EntityFrameworkCore;
using BackendAPI2.Models;

namespace BackendAPI2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<AppDocument> Documents { get; set; }
    }
}
