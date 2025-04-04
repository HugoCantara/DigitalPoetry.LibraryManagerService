using DigitalPoetry.LibraryManager.Service.Application.Mappers;
using DigitalPoetry.LibraryManager.Service.Infra.IoC.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

// ******************************
// Add variables.
// ******************************

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);
ConfigurationManager? configuration = builder.Configuration;

// ******************************
// Add services to the container.
// ******************************

// Add Configuration Manager
builder.Services.AddConfiguration(configuration);
// Add Controllers
builder.Services.AddControllers();
// Add Endpoints API Explorer
builder.Services.AddEndpointsApiExplorer();
// Add Swagger
builder.Services.AddSwaggerGen(o => AddSwaggerDocumentation(o));
// Add Context
builder.Services.AddConfiguredContext(configuration);
// Add Repositories
builder.Services.AddRepositories();
// Add Mappers
builder.Services.AddAutoMapper(typeof(MapperEntitiesToDTO));

// ******************************
// Build Web Application.
// ******************************

WebApplication? app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DigitalPoetry.LibrayManagerService.API v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void AddSwaggerDocumentation(SwaggerGenOptions o)
{
    string? xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    o.SwaggerDoc("v1", new OpenApiInfo { Title = "DigitalPoetry.LibrayManagerService.API", Version = "v1" });
    o.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
}
