using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AccesoDatos.Datos;

public class DBHelper
{
    SqlConnection conexion;
    SqlCommand comando;

    private static DBHelper? instancia;

    public DBHelper()
    {
        conexion = new SqlConnection(Properties.Resources.cadena_conexion);
        comando = new SqlCommand();
        comando.Connection = conexion;
    }

    public static DBHelper ObtenerInstancia()
    {
        if (instancia == null)
        {
            instancia = new DBHelper();
        }

        return instancia;
    }

    public void AbreConexionConTransaccion()
    {
        try
        {
            conexion.Open();
            comando.Transaction = conexion.BeginTransaction();
        }
        catch (SqlException ex)
        {
            if (comando.Transaction != null)
                comando.Transaction.Rollback();
            if (conexion != null && conexion.State == ConnectionState.Open)
                conexion.Close();
            throw ex;
        }
    }

    public void CierraConexionConTransaccion()
    {
        try
        {
            comando.Transaction.Commit();
            conexion.Close();
        }
        catch (SqlException ex)
        {
            if (comando.Transaction != null)
                comando.Transaction.Rollback();
            if (conexion != null && conexion.State == ConnectionState.Open)
                conexion.Close();
            throw ex;
        }
    }

    public DataTable CargarTabla(string SP, List<SqlParameter>? lista_parametros = null)
    {
        try
        {
            DataTable Tabla = new DataTable();
            while (conexion.State != ConnectionState.Closed) { }
            conexion.Open();
            comando.CommandText = SP;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            if (lista_parametros != null)
            {
                foreach (SqlParameter param in lista_parametros)
                {
                    comando.Parameters.Add(param);
                }
            }
            Tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return Tabla;
        }
        catch (SqlException ex)
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
                conexion.Close();
            throw ex;
        }
    }

    public DataTable CargarTablaEnTransaccion(string SP, List<SqlParameter>? lista_parametros = null)
    {
        try
        {
            DataTable Tabla = new DataTable();
            comando.CommandText = SP;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            if (lista_parametros != null)
            {
                foreach (SqlParameter param in lista_parametros)
                {
                    comando.Parameters.Add(param);
                }
            }
            Tabla.Load(comando.ExecuteReader());
            return Tabla;
        }
        catch (SqlException ex)
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
                conexion.Close();
            throw ex;
        }
    }

    public int EjecutaComando(string SP, List<SqlParameter> lista_param, SqlParameter? salida)
    {
        try
        {
            int resultado = -1;
            comando.Parameters.Clear();
            comando.CommandText = SP;
            comando.CommandType = CommandType.StoredProcedure;
            if (salida != null)
                comando.Parameters.Add(salida);
            foreach (SqlParameter param in lista_param)
                comando.Parameters.Add(param);
            comando.ExecuteNonQuery();
            if (salida != null)
                resultado = (int)salida.Value;
            else
                resultado = 0;
            return resultado;
        }
        catch (SqlException ex)
        {
            if (comando.Transaction != null)
                comando.Transaction.Rollback();
            if (conexion != null && conexion.State == ConnectionState.Open)
                conexion.Close();
            throw ex;
        }
    }
}
