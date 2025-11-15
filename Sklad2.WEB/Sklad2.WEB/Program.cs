//using Sklad2.WEB.Client.Pages;
using Sklad2.WEB.Components;
using Mapster;
using Sklad2.Core;
using Sklad2.Core.IReposytories;
using Sklad2.DAL;
using Sklad2.BLL;
using Sklad2.Core.MappsterStuff;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace Sklad2.WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();


            builder.Services.AddDbContext<DataContext>();

            builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();

            builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();

            builder.Services.AddScoped<IScrapTypeRepository, ScrapTypeRepository>();

            builder.Services.AddScoped<Service>();

            builder.Services.AddScoped<IUserRepository, UserRepository>();

            builder.Services.AddScoped<IWareHouseRepository, WareHouseRepository>();

            


            TypeAdapterConfig.GlobalSettings.Apply(new MapsterConfig());
            builder.Services.AddMapster();


            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(
                    options =>
                    {
                        options.LoginPath = "/login";
                        options.Cookie.Name = "auth_token";
                        options.Cookie.MaxAge = TimeSpan.FromMinutes(30);
                    });

            builder.Services.AddAuthorization();
            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddHttpContextAccessor();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

            app.Run();
        }
    }
}
