using EmptyFinalProject.Models;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EmptyFinalProject
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			var connectionString = builder.Configuration.GetConnectionString("ParkViewDbConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");


			builder.Services.AddControllersWithViews();
			builder.Services.AddScoped<ISportsRepo, SportsDbRepo>();
			builder.Services.AddScoped<ICategoryRepo, CategoryDbRepo>();



			builder.Services.AddDbContext<SportsDbContext>(options => 
			options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")) );



			builder.Services.AddDefaultIdentity<IdentityUser>()
				.AddEntityFrameworkStores<SportsDbContext>();

			builder.Services.AddAuthentication().AddGoogle(
                googleoptions =>
                {
                    googleoptions.ClientId = builder.Configuration["Authentication:Google:ClientID"];
                    googleoptions.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];
                }
    );

            builder.Services.AddAuthentication().AddFacebook(
    facebookoptions =>
    {
        facebookoptions.ClientId = builder.Configuration["Authentication:Facebook:AppID"];
        facebookoptions.ClientSecret = builder.Configuration["Authentication:Facebook:AppSecret"];
    }
    );

            builder.Services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));

			builder.Services.AddHttpContextAccessor();

			builder.Services.AddSession();

			var app = builder.Build();

			app.UseStaticFiles();

			app.UseSession();

			app.UseAuthentication();

			app.UseAuthorization();

			app.MapRazorPages();

			app.MapDefaultControllerRoute();
               
			app.UseAuthentication(); ;

			app.Run();
		}
	}
}