using Dapper;
using Microsoft.AspNetCore.Mvc;
using MiApiCuadrado.Data;
using MiApiCuadrado.Models;

namespace MiApiCuadrado.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstudiantesController : ControllerBase
    {
        private readonly Database _database;

        public EstudiantesController(Database database)
        {
            _database = database;
        }

        // GET: api/Estudiantes
        [HttpGet]
        public async Task<IActionResult> ObtenerEstudiantes()
        {
            using var connection = _database.CreateConnection();

            const string sql = @"
                SELECT
                    id_estudiante AS IdEstudiante,
                    nombre AS Nombre,
                    apellido AS Apellido,
                    matricula AS Matricula,
                    fecha_nacimiento AS FechaNacimiento,
                    fecha_ingreso AS FechaIngreso,
                    carrera AS Carrera,
                    correo AS Correo,
                    telefono AS Telefono
                FROM estudiantes
                ORDER BY id_estudiante ASC";

            var estudiantes = await connection.QueryAsync<Estudiante>(sql);

            return Ok(estudiantes);
        }

        // POST: api/Estudiantes
        [HttpPost]
        public async Task<IActionResult> CrearEstudiante(Estudiante estudiante)
        {
            using var connection = _database.CreateConnection();

            const string sql = @"
                INSERT INTO estudiantes
                (
                    nombre,
                    apellido,
                    matricula,
                    fecha_nacimiento,
                    fecha_ingreso,
                    carrera,
                    correo,
                    telefono
                )
                VALUES
                (
                    @Nombre,
                    @Apellido,
                    @Matricula,
                    @FechaNacimiento,
                    @FechaIngreso,
                    @Carrera,
                    @Correo,
                    @Telefono
                );

                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            estudiante.IdEstudiante =
                await connection.ExecuteScalarAsync<int>(sql, estudiante);

            return Ok(estudiante);
        }
    }
}