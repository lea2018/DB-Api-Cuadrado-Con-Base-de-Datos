using Microsoft.EntityFrameworkCore;
using MiApiCuadrado.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddDbContext<DBApiCuadradoContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DBApiCuadrado")
    ));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();