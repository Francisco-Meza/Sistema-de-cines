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
        private string nombrePelicula, duracion, hora;
        private int clasificacion, genero, sala, idioma;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                this.idCine = cmbCine.SelectedIndex+1;
                nombrePelicula = txtNombre.Text;
                duracion = txtDuracion.Text;
                hora = txtHora.Text;
                clasificacion = Convert.ToInt32(cmbClasificacion.SelectedValue);
                genero = Convert.ToInt32(cmbGenero.SelectedValue);
                sala = Convert.ToInt32(cmbSala.SelectedValue);
                idioma = Convert.ToInt32(cmbIdioma.SelectedValue);
                string msj = ClsPeliculas_N.Create(idCine,nombrePelicula, duracion, clasificacion, idioma, genero, sala, hora);
                if (msj.Equals("OK"))
                {
                    MessageBox.Show("Se registro con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (msj.Equals("NO"))
                {
                    MessageBox.Show("No se pudo registrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                nombrePelicula = txtNombre.Text;
                duracion = txtDuracion.Text;
                hora = txtHora.Text;
                clasificacion = Convert.ToInt32(cmbClasificacion.SelectedValue);
                genero = Convert.ToInt32(cmbGenero.SelectedValue);
                sala = Convert.ToInt32(cmbSala.SelectedValue);
                idioma = Convert.ToInt32(cmbIdioma.SelectedValue);
                string msj = ClsPeliculas_N.Update(this.idCine,this.id,nombrePelicula, duracion, clasificacion, idioma, genero, sala, hora);
                if (msj.Equals("OK"))
                {
                    MessageBox.Show("Se registro con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (msj.Equals("NO"))
                {
                    MessageBox.Show("No se pudo registrar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private int id;
        private int idCine;
        public FrmAddPelicula()
        {
            id = 0;
            InitializeComponent();
            iniciarCombos();
            cmbCine.SelectedIndex = 1;
        }
        public FrmAddPelicula(int id, int idCine)
        {
            this.id = id;
            this.idCine = idCine;
            Console.WriteLine(this.id);
            InitializeComponent();
            iniciarCombos();
            DataTable datos = new DataTable();
            datos = ClsPeliculas_N.Read(id, idCine);
            txtNombre.Text = datos.Rows[0][0].ToString();
            txtDuracion.Text = datos.Rows[0][1].ToString();
            txtHora.Text = datos.Rows[0][5].ToString();
            cmbClasificacion.SelectedValue = Convert.ToInt32(datos.Rows[0][2]);
            cmbGenero.SelectedValue = Convert.ToInt32(datos.Rows[0][3]);
            cmbIdioma.SelectedValue = Convert.ToInt32(datos.Rows[0][4]);
            cmbSala.SelectedValue = Convert.ToInt32(datos.Rows[0][6]);
        }
        private void iniciarCombos()
        {
            cmbClasificacion.DataSource = ClsPeliculas_N.ReadClasificacion();
            cmbClasificacion.DisplayMember = "NOMBRE";
            cmbClasificacion.ValueMember = "ID";
            //-------------------------------------------------------
            cmbGenero.DataSource = ClsPeliculas_N.ReadGenero();
            cmbGenero.DisplayMember = "NOMBRE";
            cmbGenero.ValueMember = "ID";
            //-------------------------------------------------------
            cmbIdioma.DataSource = ClsPeliculas_N.ReadIdioma();
            cmbIdioma.DisplayMember = "NOMBRE";
            cmbIdioma.ValueMember = "ID";
            //-------------------------------------------------------
            cmbSala.DataSource = ClsPeliculas_N.ReadSala();
            cmbSala.DisplayMember = "NOMBRE";
            cmbSala.ValueMember = "ID";

            cmbCine.Items.Add("IXTLAN");
            cmbCine.Items.Add("TEQUILA");
        }
    }
}
