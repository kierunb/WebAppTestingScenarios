using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Hosting;

namespace SimpleWebApplication.IntegrationTests
{
    /// add this in tested app 'Program.cs' file
    /// public partial class Program { } // so you can reference it from tests

    public class SimpleWebApplicationFactory : WebApplicationFactory<Program>
    {
        protected override IHost CreateHost(IHostBuilder builder)
        {
            var root = new InMemoryDatabaseRoot();

            //builder.ConfigureServices(services =>
            //{
            //    services.RemoveAll(typeof(DbContextOptions<NotesDbContext>));
            //    services.AddDbContext<NotesDbContext>(options =>
            //        options.UseInMemoryDatabase("Testing", root));
            //});

            return base.CreateHost(builder);
        }
    }
}
