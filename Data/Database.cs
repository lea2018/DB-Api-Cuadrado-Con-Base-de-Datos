using Microsoft.Data.SqlClient;

namespace MiApiCuadrado.Data
{
    public class Database
    {
        private readonly IConfiguration _configuration;

        public Database(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public SqlConnection CreateConnection()
        {
            var connectionString = _configuration.GetConnectionString("DBApiCuadrado");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException(
                    "No se encontró la cadena de conexión 'DBApiCuadrado'."
                );
            }

            return new SqlConnection(connectionString);
        }
    }
}