using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSINESS;

namespace Sistema_de_cines
{
    public partial class FrmAddPelicula : Form
    {
        ClsPeliculas_N peliculas;
        private string nombrePelicula, duracion, portada, formato, clasificacion, idioma, genero, hora;
        private int sala;
        private int id;
    }
}
