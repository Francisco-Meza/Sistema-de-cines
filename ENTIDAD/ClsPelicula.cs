using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class ClsPelicula
    {
        private string _nombrePelicula;
        private int _genero;
        private string _portada;
        private int _clasificacion;
        private string _formato;
        private int _idioma;
        private string _hora;
        private string _duracion;
        private int _sala;
        private int _idPelicula;
        private int _idCine;

        public string NombrePelicula 
        { get => _nombrePelicula; set => _nombrePelicula = value; }
        public int Genero
        { get => _genero; set => _genero = value; }
        public string Portada
        { get => _portada; set => _portada = value; }
        public int Clasificacion
        { get => _clasificacion; set => _clasificacion = value; }
        public string Formato
        { get => _formato; set => _formato = value; }
        public int Idioma
        { get => _idioma; set => _idioma = value; }
        public string Hora
        { get => _hora; set => _hora = value; }
        public string Duracion
        { get => _duracion; set => _duracion = value; }
        public int IdPelicula
        { get => _idPelicula; set => _idPelicula = value; }
        public int Sala
        { get => _sala; set => _sala = value; }
        public int IdCine { get => _idCine; set => _idCine = value; }
    }
}
