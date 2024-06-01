using Microsoft.EntityFrameworkCore;
using TimeInSoftware.Models;

namespace TimeInSoftware.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BookingDetails> BookingDetails { get; set; }
    }
    
}
