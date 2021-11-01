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
            services.AddScoped<CanalAppService>();
            services.AddScoped<CanalDomainService>();
            services.AddScoped<CaracteristicaZonaAppService>();
            services.AddScoped<CaracteristicaZonaDomainService>();
            services.AddScoped<CiudadAppService>();
            services.AddScoped<CiudadDomainService>();
            services.AddScoped<CompaniaAppService>();
            services.AddScoped<CompaniaDomainService>();
            services.AddScoped<DepartamentoAppService>();
            services.AddScoped<DepartamentoDomainService>();
            services.AddScoped<FormaAtencionAppService>();
            services.AddScoped<FormaAtencionDomainService>();
            services.AddScoped<PuntoPosAppService>();
            services.AddScoped<PuntoPosDomainService>();
            services.AddScoped<PuntoRejasAppService>();
            services.AddScoped<PuntoRejasDomainService>();
            services.AddScoped<RamoAppService>();
            services.AddScoped<RamoDomainService>();
            services.AddScoped<SegmentacionAppService>();
            services.AddScoped<SegmentacionDomainService>();
            services.AddScoped<SegmentoAppService>();
            services.AddScoped<SegmentoDomainService>();
            services.AddScoped<TamanoAppService>();
            services.AddScoped<TamanoDomainService>();
            services.AddScoped<TerritorioAppService>();
            services.AddScoped<TerritorioDomainService>();
            services.AddScoped<TipoClienteAppService>();
            services.AddScoped<TipoClienteDomainService>();
            services.AddScoped<TipoEmpresaAppService>();
            services.AddScoped<TipoEmpresaDomainService>();
            services.AddScoped<TipoReferenciaAppService>();
            services.AddScoped<TipoReferenciaDomainService>();
            services.AddScoped<TipoZonaAppService>();
            services.AddScoped<TipoZonaDomainService>();
            services.AddScoped<UsuarioAppService>();
            services.AddScoped<UsuarioDomainService>();
            services.AddScoped<ZonaEntregaAppService>();
            services.AddScoped<ZonaEntregaDomainService>();
            services.AddScoped<GestionAppService>();
            services.AddScoped<GestionDomainService>();
            services.AddScoped<AperturaAppService>();
            services.AddScoped<AperturaDomainService>();

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
