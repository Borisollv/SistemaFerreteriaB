using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAplicacion
{
    public class logCliente
    {
        #region singleton
        private static readonly logCliente UnicaInstancia = new logCliente();
        public static logCliente Instancia
        {
            get
            {
                return UnicaInstancia;
            }
        }
        #endregion
        #region metodos

        public List<Cliente> ListarCliente()
        {
            try
            {
                return datCliente.Instancia.ListarCliente();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Cliente BuscarCliente()
        {
            try
            {
                return datCliente.Instancia.BuscarCliente();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Cliente InsertarCliente(Cliente cliente)
        {
            try
            {
                return datCliente.Instancia.InsertarCliente(cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Cliente EditarCliente()
        {
            try
            {
                return datCliente.Instancia.EditarCliente();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Cliente EliminarCliente()
        {
            try
            {
                return datCliente.Instancia.EliminarCliente();
            }
            catch (Exception)
            {

                throw;
            }
        }



        #endregion
    }
}
