using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Vistas
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void pbsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbmaxim_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pbmaxim.Visible = false;
            pbrestore.Visible = true;
        }

        private void pbrestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pbrestore.Visible = false;
            pbmaxim.Visible = true;
        }

        private void pbminim_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
