using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace FuncCs.Models
{
  /// <summary>
  /// FuncDbContext
  /// </summary>
  public class FuncDbContext : DbContext
  {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="options"></param>
    public FuncDbContext(DbContextOptions<FuncDbContext> options)
      : base(options)
    {
    }

    public DbSet<Todo> Todos { get; set; }
  }

  /// <summary>
  /// FuncDbContextFactory
  /// </summary>
  public class FuncDbContextFactory : IDesignTimeDbContextFactory<FuncDbContext>
  {
    /// <summary>
    /// CreateDbContext
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public FuncDbContext CreateDbContext(string[] args)
    {
      var configFileName = "local.settings.json";
      var configBuilder = new ConfigurationBuilder()
        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        .AddJsonFile(configFileName)
        .Build();

      var optionsBuilder = new DbContextOptionsBuilder<FuncDbContext>();
      optionsBuilder.UseSqlServer(configBuilder.GetConnectionString("Database"));

      return new FuncDbContext(optionsBuilder.Options);
    }
  }
}
