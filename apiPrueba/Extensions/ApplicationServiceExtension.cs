using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using apiPrueba.Services;
using Aplicacion.Contratos;
using Aplicacion.UnitOfWork;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Seguridad.TokenSeguridad;

namespace apiPrueba.Extensions;
    public static class ApplicationServiceExtension
    {
        public static void ConfigureCors (this IServiceCollection services) => 
        services.AddCors(options=>{
            options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
        });
        public static void AddApplicacionService(this IServiceCollection services){
            var key= new SymmetricSecurityKey(Encoding.UTF8.GetBytes("N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw"));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt=>{
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey=true,
                    IssuerSigningKey=key,
                    ValidateAudience=false,
                    ValidateIssuer=false

                };
            });
            services.AddScoped<IJwtGenerador, JwtGenerador>();
            services.AddScoped<IPasswordHasher<Usuario>,PasswordHasher<Usuario>> ();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }