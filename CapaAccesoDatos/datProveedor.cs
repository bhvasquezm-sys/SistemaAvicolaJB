using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datProveedor
    {
        #region singleton
        private static readonly datProveedor _instancia = new datProveedor();
        public static datProveedor Instancia
        {
            get { return datProveedor._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor Prv = new entProveedor();
                    Prv.idProveedor = Convert.ToInt32(dr["idProveedor"]);
                    Prv.rucProveedor = dr["rucProveedor"].ToString();
                    Prv.razonSocial = dr["razonSocial"].ToString();
                    Prv.telefono = dr["telefono"].ToString();
                    Prv.correo = dr["correo"].ToString();
                    Prv.fecRegProveedor = Convert.ToDateTime(dr["fecRegProveedor"]);
                    Prv.estProveedor = Convert.ToBoolean(dr["estProveedor"]);
                    lista.Add(Prv);
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

        public Boolean InsertarProveedor(entProveedor Prv)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rucProveedor", Prv.rucProveedor);
                cmd.Parameters.AddWithValue("@razonSocial", Prv.razonSocial);
                cmd.Parameters.AddWithValue("@telefono", Prv.telefono);
                cmd.Parameters.AddWithValue("@correo", Prv.correo);
                cmd.Parameters.AddWithValue("@fecRegProveedor", Prv.fecRegProveedor);
                cmd.Parameters.AddWithValue("@estProveedor", Prv.estProveedor);
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

        public Boolean EditarProveedor(entProveedor Prv)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", Prv.idProveedor);
                cmd.Parameters.AddWithValue("@rucProveedor", Prv.rucProveedor);
                cmd.Parameters.AddWithValue("@razonSocial", Prv.razonSocial);
                cmd.Parameters.AddWithValue("@telefono", Prv.telefono);
                cmd.Parameters.AddWithValue("@correo", Prv.correo);
                cmd.Parameters.AddWithValue("@fecRegProveedor", Prv.fecRegProveedor);
                cmd.Parameters.AddWithValue("@estProveedor", Prv.estProveedor);
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

        public Boolean DeshabilitarProveedor(entProveedor Prv)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", Prv.idProveedor);
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
