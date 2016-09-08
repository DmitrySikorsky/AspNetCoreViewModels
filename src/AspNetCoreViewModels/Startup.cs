
using AspNetCoreViewModels.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreViewModels
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
      services.AddScoped<IStorage, Storage>();
    }

    public void Configure(IApplicationBuilder applicationBuilder)
    {
      applicationBuilder.UseStaticFiles();
      applicationBuilder.UseMvc(
        configureRoutes =>
        {
          configureRoutes.MapRoute("Calendar", string.Empty, new { controller = "Default", action = "Calendar" });
        }
      );
    }
  }
}