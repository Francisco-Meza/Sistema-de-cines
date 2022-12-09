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
    public partial class FrmPeliculas : Form
    {
        private DataTable datos;
        //private ClsPeliculas_N
        public FrmPeliculas()
        {
            InitializeComponent();
            datos = ClsPeliculas_N.Read();
            dgvPeliculas.DataSource = datos;
            dgvPeliculas.Columns[0].Visible = false;
            dgvPeliculas.Columns[1].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddPelicula frmPE = new FrmAddPelicula();
            frmPE.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int row = dgvPeliculas.CurrentRow.Index;
            int id = Convert.ToInt32(dgvPeliculas.Rows[row].Cells[1].Value);
            int idCine = Convert.ToInt32(dgvPeliculas.Rows[row].Cells[0].Value);
            FrmAddPelicula frmPE = new FrmAddPelicula(id, idCine);
            frmPE.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int row = dgvPeliculas.CurrentRow.Index;
            int id = Convert.ToInt32(dgvPeliculas.Rows[row].Cells[1].Value);
            int idCine = Convert.ToInt32(dgvPeliculas.Rows[row].Cells[0].Value);
            string msj = ClsPeliculas_N.Delete(idCine,id);
            if (msj.Equals("OK"))
            {
                MessageBox.Show("Se elimino con exito", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            datos = ClsPeliculas_N.Read();
            dgvPeliculas.DataSource = datos;
        }
    }
}
