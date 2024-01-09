using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ContentManagementSystem.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ContentManagementSystemDbContextFactory : IDesignTimeDbContextFactory<ContentManagementSystemDbContext>
{
    public ContentManagementSystemDbContext CreateDbContext(string[] args)
    {
        ContentManagementSystemEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ContentManagementSystemDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ContentManagementSystemDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ContentManagementSystem.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
