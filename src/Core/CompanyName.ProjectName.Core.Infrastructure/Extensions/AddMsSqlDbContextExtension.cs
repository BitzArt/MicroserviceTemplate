using CompanyName.ProjectName.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyName.ProjectName
{
    public static class AddMsSqlDbContextExtension
    {
        public static IServiceCollection AddMsSqlDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MsSqlAppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Db"),
            o => { o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);}));

            services.AddTransient<AppDbContext>(x => x.GetRequiredService<MsSqlAppDbContext>());

            return services;
        }
    }
}
