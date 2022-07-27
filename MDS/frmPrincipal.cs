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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPuntajes_Click(object sender, EventArgs e)
        {
            frmPuntajes ventana = new frmPuntajes();
            ventana.Show();
        }

     

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
