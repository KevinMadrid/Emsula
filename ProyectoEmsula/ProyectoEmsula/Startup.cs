using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoEmsula.ApplicationServices;
using ProyectoEmsula.DataContext;
using ProyectoEmsula.DomainServices;
using ProyectoEmsula.ApplicationService;
using ProyectoEmsula.DomainService;

namespace ProyectoEmsula
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
            services.AddDbContext<EmsulaDataContext>();
            services.AddScoped<ClienteAppService>();
            services.AddScoped<ClienteDomainService>();
            services.AddScoped<NegocioAppService>();
            services.AddScoped<NegocioDomainService>();
            services.AddScoped<UsuarioAppService>();
            services.AddScoped<UsuarioDomainService>();
            services.AddScoped<DatoEmsulaAppService>();
            services.AddScoped<DatoEmsulaDomainService>();
            services.AddScoped<UbicacionAppService>();
            services.AddScoped<UbicacionDomainService>();
            services.AddScoped<DatoAppService>();
            services.AddScoped<DatoDomainService>();

            services.AddMvc()
                 .AddJsonOptions(Options => Options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2); ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder =>
            {
                builder.WithOrigins("*");
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            });
            app.UseMvc();
        }
    }
}
