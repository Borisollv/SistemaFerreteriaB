using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using CapaAccesoDatos;

namespace CapaDatos
{
    public class datCliente
    {
        #region singleton
        private static readonly datCliente UnicaInstancia = new datCliente();
        public static datCliente Instancia
        {
            get
            {
                return UnicaInstancia;
            }
        }
        #endregion
        #region metodos

        //Listar CLiente
        public List<Cliente> ListarCliente()
        {
            List<Cliente> lista = new List<Cliente>();
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Cliente a = new Cliente();
                    a.idCliente = Convert.ToInt32(dr["idCliente"]);
                    a.nombres = Convert.ToString(dr["nombres"]);
                    a.apellidos = Convert.ToString(dr["apellidos"]);
                    a.direccion = Convert.ToString(dr["direccion"]);
                    a.celular = Convert.ToString(dr["celular"]);

                    lista.Add(a);
                }
                cn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lista;
        }

        //Buscar CLiente
        public Cliente BuscarCliente()
        {
            Cliente a = null;
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    a = new Cliente();
                    a.idCliente = Convert.ToInt32(dr["idCliente"]);
                    a.nombres = Convert.ToString(dr["nombres"]);
                    a.apellidos = Convert.ToString(dr["apellidos"]);
                    a.direccion = Convert.ToString(dr["direccion"]);
                    a.celular = Convert.ToString(dr["celular"]);

                }
                cn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return a;
        }

        //Insetar Cliente
        public Cliente InsertarCliente(Cliente cliente)
        {
            Cliente clienteInsertado = null;
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); 
                cmd = new SqlCommand("spInsertarCliente", cn); 
                cmd.CommandType = CommandType.StoredProcedure;

                
                cmd.Parameters.AddWithValue("@prmnombres", cliente.nombres);
                cmd.Parameters.AddWithValue("@prmapellidos", cliente.apellidos);
                cmd.Parameters.AddWithValue("@prmdireccion", cliente.direccion);
                cmd.Parameters.AddWithValue("@prmcelular", cliente.celular);

                
                cn.Open();
                cmd.ExecuteNonQuery(); 

             
                clienteInsertado = cliente;
                cn.Close();
            }
            catch (Exception ex)
            {
                throw ex; 
            }

            return clienteInsertado; 
        }



        // Editar Cliente
        public Cliente EditarCliente()
        {
            Cliente a = null;
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmidCliente", a.idCliente);
                cmd.Parameters.AddWithValue("@prmnombres", a.nombres);
                cmd.Parameters.AddWithValue("@prapellidos", a.apellidos);
                cmd.Parameters.AddWithValue("@prmdireccion", a.direccion);
                cmd.Parameters.AddWithValue("@prmcelular", a.celular);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    a = new Cliente();
                    a.idCliente = Convert.ToInt32(dr["idCliente"]);
                    a.nombres = Convert.ToString(dr["nombres"]);
                    a.apellidos = Convert.ToString(dr["apellidos"]);
                    a.direccion = Convert.ToString(dr["direccion"]);
                    a.celular = Convert.ToString(dr["celular"]);

                }
                cn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return a;
        }


        // Eliminar Cliente
        public Cliente EliminarCliente()
        {
            Cliente a = null;
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmidCliente", a.idCliente);
                cmd.Parameters.AddWithValue("@prmnombres", a.nombres);
                cmd.Parameters.AddWithValue("@prapellidos", a.apellidos);
                cmd.Parameters.AddWithValue("@prmdireccion", a.direccion);
                cmd.Parameters.AddWithValue("@prmcelular", a.celular);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    a = new Cliente();
                    a.idCliente = Convert.ToInt32(dr["idCliente"]);
                    a.nombres = Convert.ToString(dr["nombres"]);
                    a.apellidos = Convert.ToString(dr["apellidos"]);
                    a.direccion = Convert.ToString(dr["direccion"]);
                    a.celular = Convert.ToString(dr["celular"]);

                }
                cn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return a;
        }    
       
    }

}

        #endregion


