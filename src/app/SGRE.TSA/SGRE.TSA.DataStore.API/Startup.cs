using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SGRE.TSA.DataStore.API.Providers;

namespace SGRE.TSA.DataStore.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAssignRoles, AssignRoles>();
            services.AddScoped<IDesignEvaluation, DesignEvaluation>();

            services.AddDbContextPool<TsaContext>(o =>
            {
                o.UseNpgsql(Configuration.GetConnectionString(@"MyWebApiConection")).UseSnakeCaseNamingConvention();

            });
            services.AddControllers()
             .AddNewtonsoftJson(options =>
                 options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
              );

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SGRE.TSA.DataStore.API", Version = "v1" });
            });

            services.AddOData();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, TsaContext tsaContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SGRE.TSA.DataStore.API v1"));
            }

            // Developers Comment: Below cmd increases load time during runtime.
            //tsaContext.Database.Migrate();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                endpoints.EnableDependencyInjection();

                endpoints.Expand().Select(Microsoft.AspNet.OData.Query.QueryOptionSetting.Allowed).OrderBy().Filter().MaxTop(100).Count();

            });


        }

    }
}
