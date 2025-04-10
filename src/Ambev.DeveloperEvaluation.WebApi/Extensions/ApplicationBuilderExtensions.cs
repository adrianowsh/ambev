using Ambev.DeveloperEvaluation.ORM;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.WebApi.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static async Task ApplyMigrationsAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            await using var applicationDbContext =
                scope.ServiceProvider.GetRequiredService<DefaultContext>();

            //await using ApplicationIdentityDbContext identityDbContext =
            //    scope.ServiceProvider.GetRequiredService<ApplicationIdentityDbContext>();

            try
            {
                await applicationDbContext.Database.MigrateAsync();
                app.Logger.LogInformation("Application database migrations applied successfully.");

                //await identityDbContext.Database.MigrateAsync();
                //app.Logger.LogInformation("Identity database migrations applied successfully.");
            }
            catch (Exception e)
            {
                app.Logger.LogError(e, "An error occurred while applying database migrations.");
                throw;
            }
        }
    }
}
