using Compendium.Repository;
using Compendium.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Compendium
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
            // Register services
            services.AddScoped<IBoardGameService, BoardGameService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<ILoanService, LoanService>();

            // Register repositories
            services.AddScoped<IBoardGameRepository, BoardGameRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<ILoanedBoardGameRepository, LoanedBoardGameRepository>();
            services.AddScoped<ILoanedBookRepository, LoanedBookRepository>();
            services.AddScoped<ILoanedGameRepository, LoanedGameRepository>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Compendium", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Compendium v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
