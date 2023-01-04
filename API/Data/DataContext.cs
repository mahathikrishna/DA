using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

    public DbSet<AppUser> Users { get; set; } // represent table name in the DB. Columns will be what is defined in AppUser 
    }
}