using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datCondicionPago
    {
        #region singleton
        private static readonly datCondicionPago _instancia = new datCondicionPago();
        public static datCondicionPago Instancia
        {
            get { return datCondicionPago._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entCondicionPago> ListarCondicionPago()
        {
            SqlCommand cmd = null;
            List<entCondicionPago> lista = new List<entCondicionPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarCondicionPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCondicionPago Con = new entCondicionPago();
                    Con.idCondicionPago = Convert.ToInt32(dr["idCondicionPago"]);
                    Con.descripcion = dr["descripcion"].ToString();
                    Con.diasCredito = Convert.ToInt32(dr["diasCredito"]);
                    Con.modalidadEntrega = dr["modalidadEntrega"].ToString();
                    Con.fecRegCondicion = Convert.ToDateTime(dr["fecRegCondicion"]);
                    Con.estCondicionPago = Convert.ToBoolean(dr["estCondicionPago"]);
                    lista.Add(Con);
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

        public Boolean InsertarCondicionPago(entCondicionPago Con)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarCondicionPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", Con.descripcion);
                cmd.Parameters.AddWithValue("@diasCredito", Con.diasCredito);
                cmd.Parameters.AddWithValue("@modalidadEntrega", Con.modalidadEntrega);
                cmd.Parameters.AddWithValue("@fecRegCondicion", Con.fecRegCondicion);
                cmd.Parameters.AddWithValue("@estCondicionPago", Con.estCondicionPago);
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

        public Boolean EditarCondicionPago(entCondicionPago Con)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCondicionPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCondicionPago", Con.idCondicionPago);
                cmd.Parameters.AddWithValue("@descripcion", Con.descripcion);
                cmd.Parameters.AddWithValue("@diasCredito", Con.diasCredito);
                cmd.Parameters.AddWithValue("@modalidadEntrega", Con.modalidadEntrega);
                cmd.Parameters.AddWithValue("@fecRegCondicion", Con.fecRegCondicion);
                cmd.Parameters.AddWithValue("@estCondicionPago", Con.estCondicionPago);
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

        public Boolean DeshabilitarCondicionPago(entCondicionPago Con)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarCondicionPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCondicionPago", Con.idCondicionPago);
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