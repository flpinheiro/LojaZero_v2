using LojaZero.Infra.Data.User.Context;
using LojaZero.UserDomain.Entity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(WebApplication.Areas.Identity.IdentityHostingStartup))]
namespace WebApplication.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AppIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebApplicationContextConnection")));

                services.AddDefaultIdentity<AppIdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AppIdentityDbContext>();
            });
        }
    }
}