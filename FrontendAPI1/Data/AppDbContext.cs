using Microsoft.EntityFrameworkCore;
using FrontendAPI.Models;

namespace FrontendAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<AppDocument> Documents { get; set; }
    }
}
