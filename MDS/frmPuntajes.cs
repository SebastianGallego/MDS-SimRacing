using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace MDS
{
    public partial class frmPuntajes : Form
    {
        public frmPuntajes()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server= .\\SQLEXPRESS; database = BD-MDS; integrated security = true");

        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }


        public void actualizarDgvQ()
        {
            try
            {
                conexion.Open();
                string consulta = "select * from TPointQ order by Posicion";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvQ.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al abrir BD " + ex.Message);
            }
            conexion.Close();
        }

        public void actualizarDgvHeat()
        {
            try
            {
                conexion.Open();
                string consulta = "select * from TPointHeat";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvHeat.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al abrir BD " + ex.Message);
            }
            conexion.Close();
        }

        public void actualizarDgvMain()
        {
            try
            {
                conexion.Open();
                string consulta = "select * from TPointMain";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dgvMain.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al abrir BD " + ex.Message);
            }
            conexion.Close();
        }


        private void frmPuntajes_Load(object sender, EventArgs e)
        {
            actualizarDgvQ();
            actualizarDgvHeat();
            actualizarDgvMain();




        }

    

    

        private void dgvQ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbModificar.Enabled = true;
            txtPosicion.Text = dgvQ.SelectedCells[0].Value.ToString();
            txtPuntos.Text = dgvQ.SelectedCells[1].Value.ToString();


        }


    }
}
