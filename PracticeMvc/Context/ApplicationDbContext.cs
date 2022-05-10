using Microsoft.EntityFrameworkCore;
using PracticeMvc.Models;

namespace PracticeMvc.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<SimpleProject> SimpleProjects { get; set; }
    }
}
