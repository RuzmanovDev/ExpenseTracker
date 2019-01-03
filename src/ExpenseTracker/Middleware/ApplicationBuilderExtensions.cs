using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace ExpenseTracker.Middleware
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, string root)
        {
            var nodeModulesPath = Path.Combine(root, "node_modules");
            var fileProvider = new PhysicalFileProvider(nodeModulesPath);

            var options = new StaticFileOptions();
            options.RequestPath = "/node_modules";
            options.FileProvider = fileProvider;

            app.UseStaticFiles(options);

            return app;
        }
    }
}
