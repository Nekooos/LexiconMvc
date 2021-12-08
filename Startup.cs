using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LexiconMvc.Data;
using LexiconMvc.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using LexiconMvc.Models;
using Microsoft.AspNetCore.Identity;

namespace LexiconMvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IGithubRepositoriesData, GithubRepositoriesData>();
            services.AddScoped<IGuessingGameService, GuessingGameService>();
            services.AddSingleton<IPersonData, PersonData>();
            services.AddScoped<IPersonService, PersonService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddControllersWithViews();


            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddTransient<ISessionService, SessionService>();

            services.AddDbContext<LexiconMvcContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("LexiconMvcContext")));

            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.User.AllowedUserNameCharacters = null; 
                options.User.RequireUniqueEmail = true;
                })
                .AddDefaultUI()
                .AddDefaultTokenProviders()
                .AddRoles<ApplicationRole>()
                .AddEntityFrameworkStores<LexiconMvcContext>();

            services.AddRazorPages();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                 app.UseHsts();
            }
            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Site}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "repositories",
                    pattern: "repositories",
                    defaults: new { controller = "Site", Action = "ShowAllRepositories" }
                );

                endpoints.MapControllerRoute(
                    name: "fever-check",
                    pattern: "fever-check",
                    defaults: new { controller = "Doctor", Action = "FeverCheck" }
                );

                endpoints.MapControllerRoute(
                    name: "guessing-game",
                    pattern: "guessing-game",
                    defaults: new { controller = "GuessingGame", Action = "GuessingGame" }
                );

                endpoints.MapControllerRoute(
                    name: "peoples",
                    pattern: "{controller}/{action}/{searchPhrase?}",
                    defaults: new { controller = "Person", Action = "PeopleIndex" }
                );

                endpoints.MapControllerRoute(
                    name: "ajax-peoples",
                    pattern: "ajax-peoples",
                    defaults: new { controller = "AjaxPerson", Action = "AjaxPeopleIndex"}
                );

                endpoints.MapControllerRoute(
                    name: "ajax-peoples",
                    pattern: "{controller}/{action}",
                    defaults: new { controller = "AjaxPerson", Action = "GetById"}
                );

                endpoints.MapControllerRoute(
                    name: "ajax-peoples",
                    pattern: "{controller}/{action}",
                    defaults: new { controller = "AjaxPerson", Action = "Delete" }
                );

                endpoints.MapControllerRoute(
                    name: "person-language-delete",
                    pattern: "{controller}/{action}",
                    defaults: new { controller = "PersonLanguages", Action = "Delete" }
                );

                endpoints.MapRazorPages();

            });
        }
    }
}
