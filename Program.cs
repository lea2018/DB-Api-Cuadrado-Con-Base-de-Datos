using Microsoft.EntityFrameworkCore;
using MiApiCuadrado.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();

var conexion = builder.Configuration.GetConnectionString("DBApiCuadrado");

Console.WriteLine("======================================");
Console.WriteLine("CADENA DE CONEXIÓN QUE ESTÁ LEYENDO:");
Console.WriteLine(conexion);
Console.WriteLine("======================================");

builder.Services.AddDbContext<DBApiCuadradoContext>(options =>
    options.UseSqlServer(conexion)
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
// "Server=DBApiCuadrado.mssql.somee.com;Database=DBApiCuadrado;User Id=Leanny03_SQLLogin_3;Password=Lr140625;TrustServerCertificate=True;"