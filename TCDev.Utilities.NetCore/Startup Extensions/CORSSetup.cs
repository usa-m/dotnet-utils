﻿// TCDev.de 2021/08/30
// TCDev.Utilities.NetCore.CORSSetup.cs
// https://www.github.com/deejaytc/dotnet-utils

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TCDev.Utilities.NetCore.StartupExtension;

namespace TCDev.Utilities.NetCore;

public static class CorsSetup
{
   public static IServiceCollection SetupCors(this IServiceCollection services, IConfiguration config)
   {
      var corsConfig = new CorsConfig();
      config.Bind("CorsConfig", corsConfig);

      services.AddCors(options =>
      {
         options.AddPolicy(corsConfig.Name,
            builder =>
            {
               builder.AllowAnyHeader();
               if (corsConfig.AllowAllMethods) builder.AllowAnyMethod();
               if (corsConfig.AllowAllOrigins) builder.AllowAnyOrigin();

               if (!corsConfig.AllowAllMethods) builder.WithMethods(corsConfig.AllowedMethods);

               if (!corsConfig.AllowAllOrigins)
               {
                  builder.WithOrigins(corsConfig.AllowedOrigins);
                  if (corsConfig.AllowCredentials) builder.AllowCredentials();
               }


               builder.WithExposedHeaders(corsConfig.ExposedHeaders);
            });
      });

      return services;
   }

   public static IApplicationBuilder UseCorsConfigured(this IApplicationBuilder app)
   {
      var corsConfig = AppSettings.Instance.Get<CorsConfig>("CorsConfig");
      app.UseCors(corsConfig.Name);

      return app;
   }
}