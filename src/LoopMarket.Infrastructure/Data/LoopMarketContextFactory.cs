using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LoopMarket.Infrastructure.Data;

namespace LoopMarket.Infrastructure.Context;

public class LoopMarketContextFactory : IDesignTimeDbContextFactory<LoopMarketContext>
{
    public LoopMarketContext CreateDbContext(string[] args)
    {
        IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
        //Console.WriteLine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
        Console.WriteLine(Directory.GetCurrentDirectory());

        configurationBuilder.SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json");

        IConfiguration configuration = configurationBuilder.Build();
        
        DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder<LoopMarketContext>();

        optionsBuilder.UseSqlServer(configuration.GetConnectionString("LoopMarket"));

        return new LoopMarketContext(optionsBuilder.Options);
    }
}