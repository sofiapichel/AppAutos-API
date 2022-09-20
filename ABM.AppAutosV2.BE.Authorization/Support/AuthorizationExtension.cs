
using ABM.AppAutosV2.BE.Authorization.Implements;
using ABM.AppAutosV2.BE.Authorization.Interfaces;
using ABM.AppAutosV2.BE.Authorization.Support.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Threading.Tasks;

namespace ABM.AppAutosV2.BE.Authorization.Support
{
    public static class AuthorizationExtension
    {
        /// <summary>
        /// Metodo que extiende para configurar el Services
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddCustomizedAuthorization(
            this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<ITokenService, TokenService>();

            services.Configure<JwtConfig>(configuration.GetSection("JwtConfig"));

            var key = Encoding.ASCII.GetBytes(configuration["JwtConfig:Secret"]);

            services.AddHttpContextAccessor();
            services
                .AddAuthentication(option =>
                {
                    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddScheme<JwtAuthenticationOptions, JwtAuthenticationHandler>
                    (JwtAuthenticationHandler.SchemeName, o => { })
                .AddJwtBearer(jwt =>
                {
                    jwt.RequireHttpsMetadata = false;
                    jwt.SaveToken = true;
                    jwt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        RequireExpirationTime = false,
                        ValidateLifetime = true
                    };
                });
            return services;
        }
    }
}
