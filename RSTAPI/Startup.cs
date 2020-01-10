using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemberService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Repository.Core;
using Repository.Core.Adapter;
using RSTAdapter;
using RSTRepsitory;
using EntityMember = RSTRepsitory.Models.Member;
using ServiceMember = MemberService.Member;

namespace RSTAPI
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
            services.AddDbContext<RSTContext>(
                options => options.UseSqlite(Configuration["ConnectionString:Default"],
                options => options.MigrationsAssembly(typeof(Startup).Namespace)));

            services.AddScoped<IDataAdapter<ServiceMember, BaseModel<int>, int>, MemberAdapter>();

            services.AddScoped<ICreate<EntityMember, int>, MemberRepository>();
            services.AddScoped<IRead<EntityMember, int>, MemberRepository>();
            services.AddScoped<IUpdate<EntityMember, int>, MemberRepository>();
            services.AddScoped<IDelete<EntityMember, int>, MemberRepository>();

            services.AddScoped<IAuthService, AuthService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
