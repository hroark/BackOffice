using Microsoft.EntityFrameworkCore;
using static MudBlazor.Icons;

namespace BackOffice.DataStuff
{
    public class ApplicationDbContext<T> : DbContext where T : class
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext<T>> options) : base(options)
        {
        }

        public DbSet<T> Transaction { get; set; }
    }
}
