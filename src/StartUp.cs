using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(FuncCs.Startup))]
namespace FuncCs
{
  /// <summary>
  /// Startup
  /// </summary>
  public class Startup : FunctionsStartup
  {
    /// <summary>
    /// Configure
    /// </summary>
    /// <param name="builder"></param>
    public override void Configure(IFunctionsHostBuilder builder)
    {
      var services = builder.Services;

      services.AddLogging();

      #region Models.Common

      services.AddDbContext<Models.FuncDbContext>((provider, optionsBuilder) =>
      {
        var configuration = provider.GetRequiredService<IConfiguration>();
        var connectionString = configuration.GetConnectionString("Database");

        optionsBuilder.UseSqlServer(connectionString);
      });

      #endregion
    }
  }
}
