using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datCliente
    {
        #region singleton
        private static readonly datCliente _instancia = new datCliente();
        public static datCliente Instancia
        {
            get { return datCliente._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.rucDniCliente = dr["rucDniCliente"].ToString();
                    Cli.razonSocial = dr["razonSocial"].ToString();
                    Cli.direccion = dr["direccion"].ToString();
                    Cli.telefono = dr["telefono"].ToString();
                    Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);
                    Cli.estCliente = Convert.ToBoolean(dr["estCliente"]);
                    lista.Add(Cli);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean InsertarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rucDniCliente", Cli.rucDniCliente);
                cmd.Parameters.AddWithValue("@razonSocial", Cli.razonSocial);
                cmd.Parameters.AddWithValue("@direccion", Cli.direccion);
                cmd.Parameters.AddWithValue("@telefono", Cli.telefono);
                cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cmd.Parameters.AddWithValue("@rucDniCliente", Cli.rucDniCliente);
                cmd.Parameters.AddWithValue("@razonSocial", Cli.razonSocial);
                cmd.Parameters.AddWithValue("@direccion", Cli.direccion);
                cmd.Parameters.AddWithValue("@telefono", Cli.telefono);
                cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                cmd.Parameters.AddWithValue("@estCliente", Cli.estCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", Cli.idCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        #endregion metodos
    }
}