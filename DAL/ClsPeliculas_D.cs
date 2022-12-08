using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ENTIDAD;
using System.Data.SqlClient;


namespace DAL
{
    public class ClsPeliculas_D
    {
        public DataTable Read()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_PELICULAS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
        public DataTable Read(string valor)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_READ_PELICULAS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                sqlCon.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
        public string Create(ClsPelicula obj)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_CREATE_PERSONAL", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = obj.IdPelicula;
                cmd.Parameters.Add("@nombrePelicula", SqlDbType.VarChar).Value = obj.NombrePelicula;
                cmd.Parameters.Add("@duracion", SqlDbType.VarChar).Value = obj.Duracion;
                cmd.Parameters.Add("@portada", SqlDbType.VarChar).Value = obj.Portada;
                cmd.Parameters.Add("@formato", SqlDbType.VarChar).Value = obj.Formato;
                cmd.Parameters.Add("@clasificación", SqlDbType.VarChar).Value = obj.Clasificacion;
                cmd.Parameters.Add("@Hora", SqlDbType.VarChar).Value = obj.Hora;
                cmd.Parameters.Add("@sala", SqlDbType.VarChar).Value = obj.Sala;
                cmd.Parameters.Add("@idioma", SqlDbType.VarChar).Value = obj.Idioma;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() == 1) ? "OK" : "No se pudo insertar la pelicula";
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return msj;
        }

        public string Update(ClsPelicula obj)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_UPDATE_PERLICULA", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = obj.IdPelicula;
                cmd.Parameters.Add("@nombrePelicula", SqlDbType.VarChar).Value = obj.NombrePelicula;
                cmd.Parameters.Add("@duracion", SqlDbType.VarChar).Value = obj.Duracion;
                cmd.Parameters.Add("@portada", SqlDbType.VarChar).Value = obj.Portada;
                cmd.Parameters.Add("@formato", SqlDbType.VarChar).Value = obj.Formato;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() == 1) ? "OK" : "No se pudo actualizar la pelicula";
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return msj;
        }

        public string Delete(int id)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_DELETE_PELICULA", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() == 1) ? "OK" : "No se pudo eliminar la pelicula";
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return msj;
        }

    }
}
