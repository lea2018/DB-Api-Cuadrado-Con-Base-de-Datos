namespace MiApiCuadrado.Models
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public string Matricula { get; set; } = string.Empty;

        public DateTime? FechaNacimiento { get; set; }

        public DateTime? FechaIngreso { get; set; }

        public string Carrera { get; set; } = string.Empty;

        public string Correo { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;
    }
}