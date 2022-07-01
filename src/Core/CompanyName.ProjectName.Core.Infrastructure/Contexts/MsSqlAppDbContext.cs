using Microsoft.EntityFrameworkCore;

namespace CompanyName.ProjectName.Contexts
{
    public class MsSqlAppDbContext : AppDbContext
    {
        public MsSqlAppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ApplyDecimalConfiguration(modelBuilder);
        }

        private static void ApplyDecimalConfiguration(ModelBuilder modelBuilder)
        {
            var properties = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?));

            foreach (var property in properties) property.SetColumnType("decimal(18,2)");
        }
    }
}
