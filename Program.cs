using Microsoft.EntityFrameworkCore;
using Moment3.Data;
namespace Moment3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Skapar koppling till BookStoreContext
            builder.Services.AddDbContext<BookStoreDbContext>
                (options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultDbConnection"))
);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Books}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
