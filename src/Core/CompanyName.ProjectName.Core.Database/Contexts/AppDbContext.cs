using Microsoft.EntityFrameworkCore;

namespace CompanyName.ProjectName.Contexts
{
    public abstract class AppDbContext : DbContext
    {
        protected AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
