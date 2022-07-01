using BitzArt.ApiExceptions;

namespace CompanyName.ProjectName.Microservice1.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddApplication(builder.Configuration);
            builder.Services.AddInfrastructure(builder.Configuration);

            var app = builder.Build();

            app.UseRouting();

            app.ConfigureApiExceptionHandler();
            app.UseEndpoints(x => { x.MapControllers(); });

            app.Run();
        }
    }
}