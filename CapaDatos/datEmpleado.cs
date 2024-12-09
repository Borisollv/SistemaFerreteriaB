using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaAccesoDatos;

namespace CapaDatos
{
    public class datEmpleado
    {
        #region singleton
        private static readonly datEmpleado UnicaInstancia = new datEmpleado();
        public static datEmpleado Instancia
        {
            get
            {
                return UnicaInstancia;
            }
        }
        #endregion

        #region metodos
        public Empleado VerificarInicioSesion(string usuario, string contrasena)
        {
            Empleado e = null;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); 
                cmd = new SqlCommand("spVerificarInicioSesion", cn); 
                cmd.CommandType = CommandType.StoredProcedure; 
                cmd.Parameters.AddWithValue("@prmUsuario", usuario); 
                cmd.Parameters.AddWithValue("@prmContrasena", contrasena); 
                cn.Open(); 
                SqlDataReader dr = cmd.ExecuteReader(); 

                if (dr.Read())
                {
                    e = new Empleado(); 
                    e.idEmpleado = Convert.ToInt32(dr["idEmpleado"]); 
                    e.nombres = Convert.ToString(dr["Nombres"]); 
                    e.apellidos = Convert.ToString(dr["Apellidos"]); 
                    e.dni = Convert.ToInt32(dr["DNI"]); 
                    e.correo = Convert.ToString(dr["Correo"]); 
                    e.celular = Convert.ToString(dr["Celular"]); 
                    e.puesto = Convert.ToString(dr["Puesto"]); 
                }
            }

            catch (Exception)
            {
                throw;
            }

            return e;
        }
    }
}


#endregion
