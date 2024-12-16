using System.Data.SqlClient;
using System.Configuration;
using CapaDatos;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        #region singleton
        private static readonly Conexion UnicaInstancia = new Conexion();
        public static Conexion Instancia
        {
            get
            {
                return UnicaInstancia;
            }
        }
        #endregion

        #region metodos
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP - SQMIBPT\\BORIS;Initial Catalog=DBFerreteria;Integrated Security=True");
            return cn;
        }
        #endregion



    }
}
