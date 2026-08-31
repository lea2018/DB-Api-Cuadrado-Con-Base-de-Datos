using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiApiCuadrado.Models;

[Table("estudiantes")]
public class Estudiante
{
    [Key]
    [Column("id_estudiante")]
    public int IdEstudiante { get; set; }

    [Column("nombre")]
    public string Nombre { get; set; }

    [Column("apellido")]
    public string Apellido { get; set; }

    [Column("matricula")]
    public string Matricula { get; set; }

    [Column("fecha_nacimiento")]
    public DateTime? FechaNacimiento { get; set; }

    [Column("fecha_ingreso")]
    public DateTime? FechaIngreso { get; set; }

    [Column("carrera")]
    public string Carrera { get; set; }

    [Column("correo")]
    public string Correo { get; set; }

    [Column("telefono")]
    public string Telefono { get; set; }
}