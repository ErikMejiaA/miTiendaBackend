using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//codigo para llevar a cabo la conexion con la base de dstos
builder.Services.AddDbContext<miTiendaBackendContext>(optionsBuilder =>
{
    string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
}); 

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//habiliatamos las migraciones pendientes para que se esten ejecutando dinamicamente

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var loggerFactory = services.GetRequiredService<ILoggerFactory>();
    try
    {
        var context = services.GetRequiredService<miTiendaBackendContext>();
        await context.Database.MigrateAsync();
    }
    catch (Exception ex)
    {
        var logger = loggerFactory.CreateLogger<Program>();
        logger.LogError(ex, "Ocurrió un error durante la migración");
    }
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
