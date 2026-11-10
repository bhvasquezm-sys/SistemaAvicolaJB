using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=.; Initial Catalog=DBAvicolaJB; Integrated Security=true";
            return cn;
        }
    }
}