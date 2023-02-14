using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.JwtBearer; // NOTE: THIS LINE OF CODE IS NEWLY ADDED
using Microsoft.IdentityModel.Tokens; // NOTE: THIS LINE OF CODE IS NEWLY ADDED
using System.IO.Compression; // NOTE: THIS LINE OF CODE IS NEWLY ADDED
using ProTraxxWASM.Server.Db;

namespace ProTraxxWASM.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddRazorPages();

            // NOTE: THE FOLLOWING COMPRESSION RELATED LINES ARE NEWLY ADDED
            services.AddResponseCompression(options =>
            {
                options.Providers.Add<BrotliCompressionProvider>();
                options.EnableForHttps = true; // OPTIONAL - enable for sites that use HTTPS
            });
            services.Configure<BrotliCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.Optimal; // OPTIMAL is just that, not too fast or slow
            });

            // NOTE: LOCAL AUTHENTICATION CODE IS BELOW THIS LINE BUT INSIDE THIS BLOCK
            services.AddTransient<IUserDatabase, UserDatabase>();  // NOTE: LOCAL AUTHENTICATION ADDED HERE; AddTransient() IS OK TO USE BECAUSE STATE IS SAVED TO THE DRIVE

            // NOTE: THE FOLLOWING LINES ARE NEWLY ADDED
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidAudience = "acme.com",
                    ValidateIssuer = true,
                    ValidIssuer = "acme.com",
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("THIS IS YOUR SECRET KEY RIGHT HERE")) // NOTE: THIS SHOULD BE A SECRET KEY NOT TO BE SHARED
                };
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
			app.UseCors(cors => cors
				.AllowAnyMethod()
				.AllowAnyHeader()
				.SetIsOriginAllowed(origin => true)
				.AllowCredentials()
			);

			app.UseResponseCompression();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();


            app.UseAuthentication(); // NOTE: LINE IS NEWLY ADDED

			app.UseAuthorization(); // NOTE: LINE IS NEWLY ADDED, NOTICE PLACEMENT

			app.UseRouting();




			app.UseRouting();
			app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });

		}
    }
}
