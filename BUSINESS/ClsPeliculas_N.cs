using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using ENTIDAD;

namespace BUSINESS
{
    public class ClsPeliculas_N
    {
        public static DataTable Read()
        {
            ClsPeliculas_D Datos = new ClsPeliculas_D();
            return Datos.Read();
        }
        public static DataTable Read(int id, int idCine)
        {
            ClsPeliculas_D Datos = new ClsPeliculas_D();
            return Datos.Read(id,idCine);
        }
        public static string Create(int idCine, string nombrePelicula, string duracion, int clasificacion, int idioma, int genero, int sala, string hora)
        {
            ClsPeliculas_D Datos = new ClsPeliculas_D();
            ClsPelicula obj = new ClsPelicula();
            if (Validaciones.WithForCompareAsciiValue(nombrePelicula)) obj.NombrePelicula = nombrePelicula;
            else return "El nombre de la pelicula no tiene un formato correcto, intente no usar caracteres especiales";
            obj.Duracion = duracion;
            obj.Hora = hora;
            //ComboBox
            obj.Clasificacion = clasificacion;
            obj.Genero = genero;
            obj.Idioma = idioma;
            obj.Sala = sala;
            obj.IdCine = idCine;
            return Datos.Create(obj);
        }
        public static string Update(int idCine,int id, string nombrePelicula, string duracion, int clasificacion, int idioma, int genero, int sala, string hora)
        {
            ClsPeliculas_D Datos = new ClsPeliculas_D();
            ClsPelicula obj = new ClsPelicula();
            obj.IdPelicula = id;
            if (Validaciones.WithForCompareAsciiValue(nombrePelicula)) obj.NombrePelicula = nombrePelicula;
            else return "El nombre de la pelicula no tiene un formato correcto, intente no usar caracteres especiales";
            obj.Duracion = duracion;
            obj.Hora = hora;
            //ComboBox
            obj.Clasificacion = clasificacion;
            obj.Genero = genero;
            obj.Idioma = idioma;
            obj.Sala = sala;
            obj.IdCine = idCine;
            return Datos.Update(obj);
        }
        public static string Delete(int idCine,int id)
        {
            ClsPeliculas_D Datos = new ClsPeliculas_D();
            return Datos.Delete(idCine,id);
        }
        public static DataTable ReadClasificacion()
        {
            ClsPeliculas_D Datos = new ClsPeliculas_D();
            return Datos.ReadClasificacion();
        }
        public static DataTable ReadIdioma()
        {
            ClsPeliculas_D Datos = new ClsPeliculas_D();
            return Datos.ReadIdioma();
        }
        public static DataTable ReadGenero()
        {
            ClsPeliculas_D Datos = new ClsPeliculas_D();
            return Datos.ReadGenero();
        }
        public static DataTable ReadSala()
        {
            ClsPeliculas_D Datos = new ClsPeliculas_D();
            return Datos.ReadSala();
        }
    }
}
