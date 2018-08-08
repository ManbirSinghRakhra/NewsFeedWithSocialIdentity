using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NewsFeedApis
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
            services.AddMvcCore()
                .AddAuthorization()
                .AddJsonFormatters();

            //JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            services.AddAuthentication("Bearer").AddIdentityServerAuthentication(Options =>
            {
                Options.Authority = "http://localhost:5000";
                Options.RequireHttpsMetadata = false;
                Options.ApiName = "NewsFeedApis";
            });

            //services.AddAuthentication(options =>
            //{
            //    options.DefaultScheme = "Cookies";
            //    options.DefaultChallengeScheme = "oidc";

            //})
            //.AddCookie("Cookies")
            //.AddOpenIdConnect("oidc", options =>
            //{
            //    options.SignInScheme = "Cookies";
            //    options.Authority = "http://localhost:5000";
            //    options.RequireHttpsMetadata = false;
            //    options.ClientId = "client";
            //    options.SaveTokens = true;
            //});

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
