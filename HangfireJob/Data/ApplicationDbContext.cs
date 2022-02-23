using Microsoft.EntityFrameworkCore;

namespace HangfireJob.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Person>  people { get; set; }
    }
}
