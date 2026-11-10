using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datProducto
    {
        #region singleton
        private static readonly datProducto _instancia = new datProducto();
        public static datProducto Instancia
        {
            get { return datProducto._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProducto Pro = new entProducto();
                    Pro.idProducto = Convert.ToInt32(dr["idProducto"]);
                    Pro.nombreProducto = dr["nombreProducto"].ToString();
                    Pro.presentacion = dr["presentacion"].ToString();
                    Pro.pesoKg = Convert.ToDecimal(dr["pesoKg"]);
                    Pro.precioUnitario = Convert.ToDecimal(dr["precioUnitario"]);
                    Pro.fecRegProducto = Convert.ToDateTime(dr["fecRegProducto"]);
                    Pro.estProducto = Convert.ToBoolean(dr["estProducto"]);
                    lista.Add(Pro);
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

        public Boolean InsertarProducto(entProducto Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreProducto", Pro.nombreProducto);
                cmd.Parameters.AddWithValue("@presentacion", Pro.presentacion);
                cmd.Parameters.AddWithValue("@pesoKg", Pro.pesoKg);
                cmd.Parameters.AddWithValue("@precioUnitario", Pro.precioUnitario);
                cmd.Parameters.AddWithValue("@fecRegProducto", Pro.fecRegProducto);
                cmd.Parameters.AddWithValue("@estProducto", Pro.estProducto);
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

        public Boolean EditarProducto(entProducto Pro)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", Pro.idProducto);
                cmd.Parameters.AddWithValue("@nombreProducto", Pro.nombreProducto);
                cmd.Parameters.AddWithValue("@presentacion", Pro.presentacion);
                cmd.Parameters.AddWithValue("@pesoKg", Pro.pesoKg);
                cmd.Parameters.AddWithValue("@precioUnitario", Pro.precioUnitario);
                cmd.Parameters.AddWithValue("@fecRegProducto", Pro.fecRegProducto);
                cmd.Parameters.AddWithValue("@estProducto", Pro.estProducto);
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

        public Boolean DeshabilitarProducto(entProducto Pro)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", Pro.idProducto);
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