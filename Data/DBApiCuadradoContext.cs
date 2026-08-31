using Microsoft.EntityFrameworkCore;
using MiApiCuadrado.Models;

namespace MiApiCuadrado.Data
{
    public class DBApiCuadradoContext : DbContext
    {
        public DBApiCuadradoContext(DbContextOptions<DBApiCuadradoContext> options)
            : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}