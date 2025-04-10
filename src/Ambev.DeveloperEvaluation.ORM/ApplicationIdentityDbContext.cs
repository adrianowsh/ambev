using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;

namespace Ambev.DeveloperEvaluation.ORM;

//public sealed class ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options)
//    : IdentityDbContext(options)
//{
//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//modelBuilder.HasDefaultSchema(Schemas.Identity);
//        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

//        base.OnModelCreating(modelBuilder);
//    }
//}

//public sealed class ApplicationIdentityDbContextFactory : IDesignTimeDbContextFactory<ApplicationIdentityDbContext>
//{
//    public ApplicationIdentityDbContext CreateDbContext(string[] args)
//    {
//        IConfigurationRoot configuration = new ConfigurationBuilder()
//            .SetBasePath(Directory.GetCurrentDirectory())
//            .AddJsonFile("appsettings.json")
//            .Build();

//        var builder = new DbContextOptionsBuilder<ApplicationIdentityDbContext>();

//        var connectionString = configuration.GetConnectionString("DefaultConnection");

//        builder.UseNpgsql(
//            connectionString,
//            npgSqlOptions =>
//                npgSqlOptions.MigrationsHistoryTable(HistoryRepository.DefaultTableName, Schemas.Identity)
//                             .MigrationsAssembly("Ambev.DeveloperEvaluation.WebApi")
//         )
//        .UseSnakeCaseNamingConvention();

//        return new ApplicationIdentityDbContext(builder.Options);
//    }
//}