using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOGICA_DE_NEGOCIOS;

namespace ENTIDAD
{
    public class ClsPelicula
    {
        private string _nombrePelicula;
        private string _genero;
        private string _portada;
        private string _clasificacion;
        private string _formato;
        private string _idioma;
        private int _hora;
        private int _duracion;
        private int _idPelicula;

        public string NombrePeicula 
        { get => _nombrePelicula; set => _nombrePelicula = value; }
        public string Genero
        { get => _genero; set => _genero = value; }
        public string Portada
        { get => _portada; set => _portada = value; }
        public string Clasificacion
        { get => _clasificacion; set => _clasificacion = value; }
        public string Formato
        { get => _formato; set => _formato = value; }
        public string Idioma
        { get => _idioma; set => _idioma = value; }
        public int Hora
        { get => _hora; set => _hora = value; }
        public int Duracion
        { get => _duracion; set => _duracion = value; }
        public int IdPelicula
        { get => _idPelicula; set => _idPelicula = value; }
    }
}
