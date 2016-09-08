
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace AspNetCoreViewModels
{
  public class Program
  {
    public static void Main(string[] args)
    {
      IWebHost webHost = new WebHostBuilder()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseKestrel()
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      webHost.Run();
    }
  }
}