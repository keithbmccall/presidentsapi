using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PresidentsAPI.Models;

namespace PresidentsAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PresidentsContext>(opt =>
                opt.UseInMemoryDatabase("PresidentsList"));
            services.AddMvc();
            services.AddCors();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();

        }

    }
}