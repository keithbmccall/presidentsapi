using Microsoft.EntityFrameworkCore;

namespace PresidentsAPI.Models
{
    public class PresidentsContext : DbContext
    {
        public PresidentsContext(DbContextOptions<PresidentsContext> options)
            : base(options)
        {
        }
        public DbSet<PresidentsItem> PresidentsItems { get; set; }
    }
}