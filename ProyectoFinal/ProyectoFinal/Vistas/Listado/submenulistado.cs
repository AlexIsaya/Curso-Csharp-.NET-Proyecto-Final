using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Vistas.Listado
{
    public partial class submenulistado : FormBase
    {
        public submenulistado()
        {
            InitializeComponent();
            lbtitulo.Text = "Listados";
        }

        private void submenulistado_Load(object sender, EventArgs e)
        {

        }

        private void institucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoInstituciones frmc = new ListadoInstituciones();
            frmc.Show();
        }

        private void directivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDirectivos frmc = new ListadoDirectivos();
            frmc.Show();
        }

        private void gradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoGrado frmc = new ListadoGrado();
            frmc.Show();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDocentes frmc = new ListadoDocentes();
            frmc.Show();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoAlumnos frmc = new ListadoAlumnos();
            frmc.Show();
        }

        private void asignacionGradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listadoasignacion frmc = new listadoasignacion();
            frmc.Show();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoInscripciones frmc = new ListadoInscripciones();
            frmc.Show();
        }

        private void divisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDivisiones frmc = new ListadoDivisiones();
            frmc.Show();
        }

        private void nivelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoNiveles frmc = new ListadoNiveles();
            frmc.Show();
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoTurnos frmc = new ListadoTurnos();
            frmc.Show();
        }

        private void condicionDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoCondicionDocente frmc = new ListadoCondicionDocente();
            frmc.Show();
        }

        private void añoLectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoAñoLectivo frmc = new ListadoAñoLectivo();
            frmc.Show();
        }

    }
}
