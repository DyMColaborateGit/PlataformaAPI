using App.Models.Helpers;
using AspNetCoreRateLimit;
using App.Infraestructure.Profiles;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using App.logic.IServices.PTL;
using App.logic.Services.PTL;
using App.Infraestructure.IRepositories.PTL;
using App.Infraestructure.Repositories.PTL;

namespace App.logic.Extensions
{
    /// <summary>
    /// AplicationServiceExtensions
    /// </summary>
    public static class AplicationServiceExtensions
    {
        /// <summary>
        /// ConfigureCors
        /// </summary>
        public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options =>
        {
            options.AddPolicy("CorPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
        });

        /// <summary>
        /// AddAplicacionServices
        /// </summary>
        public static void AddAplicacionServices(this IServiceCollection services)
        {
            //services.AddScoped<IPasswordHasher<SCP_UsuarioModels>, PasswordHasher<SCP_UsuarioModels>>();
            services.AddScoped<IPTLSitiosService, PTLSitiosService>();
            services.AddScoped<IPTLContentsELService, PTLContentsELService>();
            services.AddScoped<IPTLEnlacesSTService, PTLEnlacesSTService>();

            services.AddScoped<IPTLRolesServices, PTLRolesServices>();
            services.AddScoped<IPTLUsuariosService, PTLUsuariosService>();
            services.AddScoped<IPTLUsuariosRolesService, PTLUsuariosRolesService>();

            services.AddScoped<IPTLAplicacionAPService, PTLAplicacionAPService>();
            services.AddScoped<IPTLModulosAPService, PTLModulosAPService>();
            services.AddScoped<IPTLVersionesAPService, PTLVersionesAPService>();
            services.AddScoped<IPTLHelpDeskTicketAPService, PTLHelpDeskTicketAPService>();
            services.AddScoped<IPTLRequerimientoHDService, PTLRequerimientoHDService>();
        }

        /// <summary>
        /// AddAplicacionRepositories
        /// </summary>
        public static void AddAplicacionRepositories(this IServiceCollection services)
        {

            services.AddScoped<IPTLSitiosRepository, PTLSitiosRepository>();
            services.AddScoped<IPTLContentsELRepository, PTLContentsELRepository>();
            services.AddScoped<IPTLEnlasesSTRepository, PTLEnlasesSTRepository>();

            services.AddScoped<IPTLRolesRespository, PTLRolesRespository>();
            services.AddScoped<IPTLUsuariosRepository, PTLUsuariosRepository>();
            services.AddScoped<IPTLUsuariosRolesRepository, PTLUsuariosRolesRepository>();

            services.AddScoped<IPTLAplicacionAPRepository, PTLAplicacionAPRepository>();
            services.AddScoped<IPTLModulosAPRepository, PTLModulosAPRepository>();
            services.AddScoped<IPTLVersionesAPRepository, PTLVersionesAPRepository>();
            services.AddScoped<IPTLHelpDeskTicketAPRepository, PTLHelpDeskTicketAPRepository>();
            services.AddScoped<IPTLRequerimientoHDRepository, PTLRequerimientoHDRepository>();
        }

        /// <summary>
        /// ConfigurateRateLimitPeticiones
        /// </summary>
        public static void ConfigurateRateLimitPeticiones(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
            services.AddInMemoryRateLimiting();

            services.Configure<IpRateLimitOptions>(options =>
            {
                options.EnableEndpointRateLimiting = true;
                options.StackBlockedRequests = false;
                options.HttpStatusCode = 429;
                options.RealIpHeader = "X-Real-IP";
                options.GeneralRules = new List<RateLimitRule>
                {
                    new RateLimitRule
                    {
                        Endpoint = "*",
                        Period = "10s",
                        Limit = 15
                    }
                };
            });
        }

        /// <summary>
        /// AddJwt
        /// </summary>
        public static void AddJwt(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigurationHelpers.TartConfiguration(configuration);
            services.Configure<JWTHelpers>(configuration.GetSection("JWT"));

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(o =>
                {
                    o.RequireHttpsMetadata = false;
                    o.SaveToken = true;
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true, 
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                        ValidIssuer = configuration["JWT:Issuer"],
                        ValidAudience = configuration["JWT:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]))
                    };
                });
        }

        /// <summary>
        /// InitMapper
        /// </summary>
        public static void InitMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AplicationServiceExtensions));
            var configMapper = new MapperConfiguration(mapConfig =>
            {
                mapConfig.AddProfile(new MappingProfiles());
            });
            var mapper = configMapper.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
