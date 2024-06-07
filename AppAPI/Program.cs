using Microsoft.EntityFrameworkCore;
using Repository.Models;
using Repository.IRepositories;
namespace AppAPI 
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the cont
            builder.Services.AddDbContext<VerssclubContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnect"));
            });
            builder.Services.AddTransient<IAllRepository<Sanpham>, Allrepso<Sanpham>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();

        }
    }
}

