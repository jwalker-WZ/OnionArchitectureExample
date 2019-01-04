using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Bookshelf;
using Domain.Inventory;
using Domain.Inventory.Attributes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Repository;
using Service;

namespace HomeServer
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
            services.AddDbContext<Repository.AppContext>(options =>
                                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IRepository<Book>), typeof(BookRepository));
            services.AddScoped(typeof(IRepository<Quote>), typeof(QuoteRepository));
            services.AddScoped(typeof(IRepository<InventoryItem>), typeof(InventoryItemRepository));

            services.AddTransient(typeof(IService<>), typeof(BaseService<>));
            services.AddTransient(typeof(IService<Book>), typeof(BookService));
            services.AddTransient(typeof(IService<Quote>), typeof(QuoteService));
            
            services.AddMvc()
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
