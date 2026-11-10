using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datInsumoProducto
    {
        #region singleton
        private static readonly datInsumoProducto _instancia = new datInsumoProducto();
        public static datInsumoProducto Instancia
        {
            get { return datInsumoProducto._instancia; }
        }
        #endregion singleton

        #region metodos
        public List<entInsumoProducto> ListarInsumoProducto()
        {
            SqlCommand cmd = null;
            List<entInsumoProducto> lista = new List<entInsumoProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarInsumoProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entInsumoProducto Ins = new entInsumoProducto();
                    Ins.idInsumo = Convert.ToInt32(dr["idInsumo"]);
                    Ins.nombreInsumo = dr["nombreInsumo"].ToString();
                    Ins.tipoMaterial = dr["tipoMaterial"].ToString();
                    Ins.unidadMedida = dr["unidadMedida"].ToString();
                    Ins.stockActual = Convert.ToDecimal(dr["stockActual"]);
                    Ins.fecRegInsumo = Convert.ToDateTime(dr["fecRegInsumo"]);
                    Ins.estInsumo = Convert.ToBoolean(dr["estInsumo"]);
                    lista.Add(Ins);
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

        public Boolean InsertarInsumoProducto(entInsumoProducto Ins)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarInsumoProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreInsumo", Ins.nombreInsumo);
                cmd.Parameters.AddWithValue("@tipoMaterial", Ins.tipoMaterial);
                cmd.Parameters.AddWithValue("@unidadMedida", Ins.unidadMedida);
                cmd.Parameters.AddWithValue("@stockActual", Ins.stockActual);
                cmd.Parameters.AddWithValue("@fecRegInsumo", Ins.fecRegInsumo);
                cmd.Parameters.AddWithValue("@estInsumo", Ins.estInsumo);
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

        public Boolean EditarInsumoProducto(entInsumoProducto Ins)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarInsumoProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInsumo", Ins.idInsumo);
                cmd.Parameters.AddWithValue("@nombreInsumo", Ins.nombreInsumo);
                cmd.Parameters.AddWithValue("@tipoMaterial", Ins.tipoMaterial);
                cmd.Parameters.AddWithValue("@unidadMedida", Ins.unidadMedida);
                cmd.Parameters.AddWithValue("@stockActual", Ins.stockActual);
                cmd.Parameters.AddWithValue("@fecRegInsumo", Ins.fecRegInsumo);
                cmd.Parameters.AddWithValue("@estInsumo", Ins.estInsumo);
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

        public Boolean DeshabilitarInsumoProducto(entInsumoProducto Ins)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarInsumoProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idInsumo", Ins.idInsumo);
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