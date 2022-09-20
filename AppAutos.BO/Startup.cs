using ABM.AppAutos.BE.Models.Profiles;
using ABM.AppAutos.BE.Repositories.Implements;
using ABM.AppAutos.BE.Repositories.Interfaces;
using ABM.AppAutos.BE.Services.Implements;
using ABM.AppAutos.BE.Services.Interfaces;
using AppAutos.DataAccess;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace AppAutos.BO
{
    public class Startup
    {
        public Startup( IConfiguration configuration )
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices( IServiceCollection services )
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", 
                    new OpenApiInfo 
                    { 
                        Title = "ABM.AppAutos.BE.API", 
                        Description = "Api de autos",
                        Version = "v1" 
                    });
            });

            
            services.AddDbContext<VehiculoDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DbVehiculos"),
    b => b.MigrationsAssembly("AppAutos.DataAccess")));

            var mapperConfig = new MapperConfiguration(m =>
            {
                m.AddProfile(new PaisProfile());
                m.AddProfile(new VehiculoProfile());
                m.AddProfile(new TipoProfile());
                m.AddProfile(new SeguroProfile());
                m.AddProfile(new MarcaProfile());
                m.AddProfile(new EstadoProfile());
                m.AddProfile(new CombustibleProfile());
                m.AddProfile(new ColorProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            #region Repositorios
            services.AddTransient<IPaisRepository, PaisRepository>();
            services.AddTransient<IVehiculoRepository, VehiculoRepository>();
            services.AddTransient<ICombustibleRepository, CombustibleRepository>();
            services.AddTransient<ITipoRepository, TipoRepository>();
            services.AddTransient<IColorRepository, ColorRepository>();
            services.AddTransient<IMarcaRepository, MarcaRepository>();
            services.AddTransient<IEstadoRepository, EstadoRepository>();
            services.AddTransient<ISeguroRepository, SeguroRepository>();
            #endregion

            #region Servicios
            services.AddTransient<ITipoService, TipoService>();
            services.AddTransient<ISeguroService, SeguroService>();
            services.AddTransient<IMarcaService, MarcaService>();
            services.AddTransient<IEstadoService, EstadoService>();
            services.AddTransient<ICombustibleService, CombustibleService>();
            services.AddTransient<IColorService, ColorService>();
            services.AddTransient<IVehiculoService, VehiculoService>();
            services.AddTransient<IPaisService, PaisService>();
            
            #endregion
            //services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure( IApplicationBuilder app, IWebHostEnvironment env )
        {
            if( env.IsDevelopment() )
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ABM.AppAutos.BE"));
                
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
