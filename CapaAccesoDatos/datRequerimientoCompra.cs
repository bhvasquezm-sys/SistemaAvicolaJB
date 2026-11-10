using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datRequerimientoCompra
    {
        #region singleton
        private static readonly datRequerimientoCompra _instancia = new datRequerimientoCompra();
        public static datRequerimientoCompra Instancia
        {
            get { return datRequerimientoCompra._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entRequerimientoCompra> ListarRequerimientoCompra()
        {
            SqlCommand cmd = null;
            List<entRequerimientoCompra> lista = new List<entRequerimientoCompra>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarRequerimientoCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRequerimientoCompra Req = new entRequerimientoCompra();
                    Req.idRequerimiento = Convert.ToInt32(dr["idRequerimiento"]);
                    Req.insumoSolicitado = dr["insumoSolicitado"].ToString();
                    Req.cantidadSolicitada = Convert.ToDecimal(dr["cantidadSolicitada"]);
                    Req.prioridad = dr["prioridad"].ToString();
                    Req.fecRegRequerimiento = Convert.ToDateTime(dr["fecRegRequerimiento"]);
                    Req.estRequerimiento = Convert.ToBoolean(dr["estRequerimiento"]);
                    lista.Add(Req);
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

        public Boolean InsertarRequerimientoCompra(entRequerimientoCompra Req)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarRequerimientoCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@insumoSolicitado", Req.insumoSolicitado);
                cmd.Parameters.AddWithValue("@cantidadSolicitada", Req.cantidadSolicitada);
                cmd.Parameters.AddWithValue("@prioridad", Req.prioridad);
                cmd.Parameters.AddWithValue("@fecRegRequerimiento", Req.fecRegRequerimiento);
                cmd.Parameters.AddWithValue("@estRequerimiento", Req.estRequerimiento);
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

        public Boolean EditarRequerimientoCompra(entRequerimientoCompra Req)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarRequerimientoCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRequerimiento", Req.idRequerimiento);
                cmd.Parameters.AddWithValue("@insumoSolicitado", Req.insumoSolicitado);
                cmd.Parameters.AddWithValue("@cantidadSolicitada", Req.cantidadSolicitada);
                cmd.Parameters.AddWithValue("@prioridad", Req.prioridad);
                cmd.Parameters.AddWithValue("@fecRegRequerimiento", Req.fecRegRequerimiento);
                cmd.Parameters.AddWithValue("@estRequerimiento", Req.estRequerimiento);
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

        public Boolean DeshabilitarRequerimientoCompra(entRequerimientoCompra Req)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarRequerimientoCompra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRequerimiento", Req.idRequerimiento);
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
