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
    public partial class formInicio : FormBase
    {
        public formInicio()
        {
            InitializeComponent();
            lbtitulo.Text = "Sistema de Inscripciones a Ciclo Escolar";
        }

        private void formInicio_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            abm.Submenualtas frmc = new abm.Submenualtas();
            frmc.ShowDialog();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Vistas.abm.abminscripcion frmc = new abm.abminscripcion();
            frmc.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Vistas.Listado.submenulistado frmc = new Vistas.Listado.submenulistado();
            frmc.ShowDialog();
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }
    }
}
