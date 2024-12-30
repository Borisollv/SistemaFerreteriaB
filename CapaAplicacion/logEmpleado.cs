using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAplicacion
{
    public class logEmpleado
    {
        #region singleton
        private static readonly logEmpleado UnicaInstancia = new logEmpleado();
        public static logEmpleado Instancia
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
            try
            {
                return datEmpleado.Instancia.VerificarInicioSesion(usuario, contrasena);
            }
            catch (Exception)
            {

                throw;
            }
        }










        #endregion
    }
}
