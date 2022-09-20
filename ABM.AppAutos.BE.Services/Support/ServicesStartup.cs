using ABM.AppAutos.BE.Services.Implements;
using ABM.AppAutos.BE.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Services.Support
{
    public static class ServicesStartup
    {
        public static IServiceCollection AddInternalServices(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddTransient<ITipoService, TipoService>();
            services.AddTransient<ISeguroService, SeguroService>();
            services.AddTransient<IMarcaService, MarcaService>();
            services.AddTransient<IEstadoService, EstadoService>();
            services.AddTransient<ICombustibleService, CombustibleService>();
            services.AddTransient<IColorService, ColorService>();
            services.AddTransient<IVehiculoService, VehiculoService>();
            services.AddTransient<IPaisService, PaisService>();
            return services;
        }
    }
}
