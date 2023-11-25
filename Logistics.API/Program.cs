
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Configurando nossa camada de persistencia
builder.Services.ConfigurePersistenceApp(builder.Configuration);
// Registrar os servi�os relacionado a camada de aplica��o
// auto mapper, mediator, fluent id
builder.Services.ConfigureApplicationApp();
builder.Services.ConfigureCorsPolicy();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var openApiInfo = new OpenApiInfo();

    openApiInfo.Title = "Fashion Trend";
    openApiInfo.Description = "Logistics";
    openApiInfo.License = new OpenApiLicense
    {
        Name = "MIT",
        Url = new Uri(@"http://www.mit.com/license")
    };
    openApiInfo.Contact = new OpenApiContact()
    {
        Name = "Giovanna Ney",
        Email = "giovanna.ney@icloud.com,
        Url = new Uri(@"https://github.com/luc0liv")
    };

    options.SwaggerDoc("v1", openApiInfo);
});

var app = builder.Build();

// Esse m�todo precisamos criar na m�o para subir nosso BD a nossa aplica��o
BD.CreateDatabase(app);

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors();
app.MapControllers();
app.Run();
