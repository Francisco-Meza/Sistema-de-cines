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
        public static DataTable Read(string valor)
        {
            ClsPeliculas_D Datos = new ClsPeliculas_D();
            return Datos.Read(valor);
        }
        public static string Create(string id, string nombrePelicula, string duracion, string portada, string formato, string clasificacion, string idioma,string genero, string sala, string hora)
        {
            ClsPeliculas_D Datos = new ClsPeliculas_D();
            ClsPelicula obj = new ClsPelicula();
            if (Validaciones.SoloNumero(id)) obj.IdPelicula = int.Parse(id);
            else return "El ID ingresado no es valido";
            if (Validaciones.WithForCompareAsciiValue(nombrePelicula)) obj.NombrePelicula = nombrePelicula;
            else return "El nombre de la pelicula no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(duracion)) obj.Duracion = duracion;
            else return "El dato no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(portada)) obj.Portada = portada;
            else return "Los datos ingresados no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(formato)) obj.Formato = formato;
            else return "Los datos ingresados no tiene un formato correcto, intente no usar caracteres especiales";
            //ComboBox
            if (Validaciones.WithForCompareAsciiValue(clasificacion)) obj.Clasificacion = clasificacion;
            else return "Los datos ingresados no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(genero)) obj.Genero = genero;
            else return "Los datos ingresados no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(idioma)) obj.Idioma = idioma;
            else return "Los datos ingresados no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.SoloNumero(sala)) obj.Sala = int.Parse(sala);
            else return "Los datos ingresados no tiene un formato correcto, intente no usar caracteres especiales";
            return Datos.Create(obj);
        }
        public static string Update(string id, string nombrePelicula, string duracion, string portada, string formato, string clasificacion, string idioma, string genero, string sala, string hora)
        {
            ClsPeliculas_D Datos = new ClsPeliculas_D();
            ClsPelicula obj = new ClsPelicula();
            if (Validaciones.SoloNumero(id)) obj.IdPelicula = int.Parse(id);
            else return "El ID ingresado no es valido";
            if (Validaciones.WithForCompareAsciiValue(nombrePelicula)) obj.NombrePelicula = nombrePelicula;
            else return "El nombre de la pelicula no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(duracion)) obj.Duracion = duracion;
            else return "El dato no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(portada)) obj.Portada = portada;
            else return "Los datos ingresados no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(formato)) obj.Formato = formato;
            else return "Los datos ingresados no tiene un formato correcto, intente no usar caracteres especiales";
            //ComboBox
            if (Validaciones.WithForCompareAsciiValue(clasificacion)) obj.Clasificacion = clasificacion;
            else return "Los datos ingresados no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(genero)) obj.Genero = genero;
            else return "Los datos ingresados no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.WithForCompareAsciiValue(idioma)) obj.Idioma = idioma;
            else return "Los datos ingresados no tiene un formato correcto, intente no usar caracteres especiales";
            if (Validaciones.SoloNumero(sala)) obj.Sala = int.Parse(sala);
            else return "Los datos ingresados no tiene un formato correcto, intente no usar caracteres especiales";
            return Datos.Create(obj);
        }
        public static string Delete(string id)
        {
            ClsPeliculas_D Datos = new ClsPeliculas_D();
            if (Validaciones.SoloNumero(id)) return Datos.Delete(int.Parse(id));
            else return "El formato del ID es incorrecto";
        }
    }
}
