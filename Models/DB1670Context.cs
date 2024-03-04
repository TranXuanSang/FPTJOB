
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Web16702401.Models;

namespace Web16702401.Models
{
    public class DB1670Context : IdentityDbContext
    {
        public DB1670Context(DbContextOptions<DB1670Context> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } 
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Web16702401.Models.Profile> Profile { get; set; } = default!;
        public DbSet<Web16702401.Models.ProJob> ProJob { get; set; } = default!;
    }
}
