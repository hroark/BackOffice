using Microsoft.EntityFrameworkCore;
using static MudBlazor.Icons;

namespace BackOffice.DataStuff;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}
