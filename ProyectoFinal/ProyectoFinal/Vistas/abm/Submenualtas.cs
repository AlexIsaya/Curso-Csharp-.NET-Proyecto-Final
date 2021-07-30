using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Vistas.abm
{
    public partial class Submenualtas : FormBase
    {
        public Submenualtas()
        {
            InitializeComponent();
            lbtitulo.Text = "Altas";
        }

        private void Submenualtas_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abminstitucion frmc = new abminstitucion();
            frmc.ShowDialog();
        }

        private void divisionesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            abmdivisiones frmc = new abmdivisiones();
            frmc.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            abmdocente frmc = new abmdocente();
            frmc.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            abmdirectivos frmc = new abmdirectivos();
            frmc.ShowDialog();
        }

        private void nivelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abmniveles frmc = new abmniveles();
            frmc.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            abmgrado frmc = new abmgrado();
            frmc.ShowDialog();
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abmturno frmc = new abmturno();
            frmc.ShowDialog();
        }

        private void condicionDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abmcondiciondocente frmc = new abmcondiciondocente();
            frmc.ShowDialog();
        }

        private void añoLectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abmañolectivo frmc = new abmañolectivo();
            frmc.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            abmalumnos frmc = new abmalumnos();
            frmc.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            abmasignaciongrado frmc = new abmasignaciongrado();
            frmc.ShowDialog();
        }
    }
}
