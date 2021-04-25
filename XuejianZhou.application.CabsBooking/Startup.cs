using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace XuejianZhou.application.CabsBooking
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "XuejianZhou.application.CabsBooking", Version = "v1" });
            });


            services.AddDbContext<CabsBookingDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("CabsBookingDbConnection")));

            services.AddScoped<IAsyncRepository<BookingsHistory>, EfRepository<BookingsHistory>>();
            services.AddScoped<IBookingsHistoryRepository, BookingsHistoryRepository>();
            services.AddScoped<IBookingsRepository, BookingsRepository>();
            services.AddScoped<IPlacesRepository, PlacesRepository>();

            services.AddScoped<ICabTypesRepository, CabTypesRepository>();


            services.AddScoped<IBookingsHistoryService, BookingsHistoryService>();
            services.AddScoped<IBookingsService, BookingsService>();
            services.AddScoped<IPlacesService, PlacesService>();
            services.AddScoped<ICabTypesService, CabTypesService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "XuejianZhou.application.CabsBooking v1"));
            }

            app.UseCors(builder =>
            {
                builder.WithOrigins(Configuration.GetValue<string>("CabsBookingSPAUrl")).AllowAnyHeader()
                    .AllowAnyMethod().AllowCredentials();
            });




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
