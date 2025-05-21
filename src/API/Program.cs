using CleanArchitecture.Application;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Infrastructure;
using API.Services;
using API.Extensions;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 配置Kestrel服务器，使其监听在0.0.0.0:5000上（仅HTTP）
            builder.WebHost.ConfigureKestrel(serverOptions =>
            {
                serverOptions.ListenAnyIP(5000); // 监听所有IP的5000端口
            });

            // Add services to the container.
            builder.Services.AddApplication();
            builder.Services.AddInfrastructure(builder.Configuration);

            builder.Services.AddSingleton<ICurrentUserService, CurrentUserService>();

            builder.Services.AddHttpContextAccessor();

            builder.Services.AddControllers();

            // 配置Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "Clean Architecture API",
                    Description = "一个基于Clean Architecture的ASP.NET Core WebAPI示例"
                });
            });

            // 配置CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            // 始终启用Swagger，而不仅仅是在开发环境
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Clean Architecture API V1");
                c.RoutePrefix = "swagger";
            });

            if (!app.Environment.IsDevelopment())
            {
                // 在生产环境中使用自定义异常处理中间件
                app.UseCustomExceptionHandler();
            }

            // 注释掉HTTPS重定向，因为我们只使用HTTP
            // app.UseHttpsRedirection();

            app.UseCors("AllowAll");

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
