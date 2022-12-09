using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClsConexion
    {
        private string _base;
        private string _servidor;
        private string _usuario;
        private string _clave;
        private bool _seguridad;
        private static ClsConexion con = null;

        private ClsConexion()
        {
            this._base = "CINEMAT_IXTLAN";
            this._servidor = Constantes.francisco;
            this._usuario = "sa";
            this._clave = "021202";
            this._seguridad = true;
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this._servidor + "; Database=" + this._base + ";";
                if (_seguridad)
                {
                    cadena.ConnectionString += "Integrated Security = SSPI;";
                }
                else
                {
                    cadena.ConnectionString += "User Id =" + this._usuario + "; Password=" + this._clave + ";";
                }
                return cadena;
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }

        public static ClsConexion GetInstancia()
        {
            if (con == null)
            {
                con = new ClsConexion();
            }
            return con;
        }
    }
}
