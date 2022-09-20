using ABM.AppAutos.BE.Repositories.Implements;
using ABM.AppAutos.BE.Repositories.Interfaces;
using ABM.AppAutos.BE.Repositories.UoW;
using Abp.Domain.Uow;
using AppAutos.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM.AppAutos.BE.Repositories.Support
{
    public static class DatabaseExtension
    {
        public static IServiceCollection AddCustomizedDatabase(this IServiceCollection services, IConfiguration Configuration)
        {
            #region Unit Of Work
            services.AddTransient<UoW.IUnitOfWork, UnitOfWork>();
            #endregion

            #region DbContext
            services.AddDbContext<VehiculoDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MotoriumDB"),
                  b => b.MigrationsAssembly("ABM.AppAutosV2.BE.API")));

            #endregion

            #region Repositories
            services.AddTransient<IPaisRepository, PaisRepository>();
            services.AddTransient<IVehiculoRepository, VehiculoRepository>();
            services.AddTransient<ICombustibleRepository, CombustibleRepository>();
            services.AddTransient<ITipoRepository, TipoRepository>();
            services.AddTransient<IColorRepository, ColorRepository>();
            services.AddTransient<IMarcaRepository, MarcaRepository>();
            services.AddTransient<IEstadoRepository, EstadoRepository>();
            services.AddTransient<ISeguroRepository, SeguroRepository>();
            #endregion

            return services;
        }
    }
}
