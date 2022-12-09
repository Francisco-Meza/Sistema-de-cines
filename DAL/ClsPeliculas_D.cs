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
                SqlCommand cmd = new SqlCommand("SP_READ_PELICULA_DISTRIBUIDA", sqlCon);
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
        public DataTable Read(int id, int idCine)
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_READ_PELICULA_DISTRIBUIDA_ID", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@CINE", SqlDbType.Int).Value = idCine;
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
                SqlCommand cmd = new SqlCommand("SP_CREATE_PELICULA", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@CINE", SqlDbType.Int).Value = obj.IdCine;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = obj.NombrePelicula;
                cmd.Parameters.Add("@DURACION", SqlDbType.VarChar).Value = obj.Duracion;
                cmd.Parameters.Add("@CLASIFICACION", SqlDbType.Int).Value = obj.Clasificacion;
                cmd.Parameters.Add("@GENERO", SqlDbType.Int).Value = obj.Genero;
                cmd.Parameters.Add("@IDIOMA", SqlDbType.Int).Value = obj.Idioma;
                cmd.Parameters.Add("@HORA", SqlDbType.VarChar).Value = obj.Hora;
                cmd.Parameters.Add("@SALA", SqlDbType.Int).Value = obj.Sala;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() == 2) ? "OK" : "No se pudo insertar la pelicula";
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
                SqlCommand cmd = new SqlCommand("SP_UPDATE_PELICULA", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = obj.IdPelicula;
                cmd.Parameters.Add("@CINE", SqlDbType.Int).Value = obj.IdCine;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = obj.NombrePelicula;
                cmd.Parameters.Add("@DURACION", SqlDbType.VarChar).Value = obj.Duracion;
                cmd.Parameters.Add("@CLASIFICACION", SqlDbType.Int).Value = obj.Clasificacion;
                cmd.Parameters.Add("@GENERO", SqlDbType.Int).Value = obj.Genero;
                cmd.Parameters.Add("@IDIOMA", SqlDbType.Int).Value = obj.Idioma;
                cmd.Parameters.Add("@HORA", SqlDbType.VarChar).Value = obj.Hora;
                cmd.Parameters.Add("@SALA", SqlDbType.Int).Value = obj.Sala;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() == 2) ? "OK" : "No se pudo actualizar la pelicula";
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

        public string Delete(int idCine,int id)
        {
            string msj = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_DELETE_PELICULA", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@CINE", SqlDbType.Int).Value = idCine;
                sqlCon.Open();
                msj = (cmd.ExecuteNonQuery() == 2) ? "OK" : "No se pudo eliminar la pelicula";
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
        public DataTable ReadClasificacion()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_READ_CLASIFICACION", sqlCon);
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
        public DataTable ReadIdioma()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_READ_IDIOMA", sqlCon);
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
        public DataTable ReadGenero()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_READ_GENERO", sqlCon);
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
        public DataTable ReadSala()
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = ClsConexion.GetInstancia().CreateConnection();
                SqlCommand cmd = new SqlCommand("SP_READ_SALA", sqlCon);
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
    }
}
