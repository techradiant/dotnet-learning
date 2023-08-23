using DotNetLearning.WebApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetLearning.WebApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }
        public DbSet<Movie> Movies { get; set; }

    }
}
