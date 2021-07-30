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
    public partial class abmturno : Formabm
    {
        public abmturno()
        {
            InitializeComponent();
            lbtitulo.Text = "Alta de Turno";
        }

        private void abmturno_Load(object sender, EventArgs e)
        {

        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Modelo.Turnos obj = new Modelo.Turnos();
            Negocio.Nturno Ntur = new Negocio.Nturno();

            obj.Descripcion = tbdescrip.Text;

            Ntur.Altas(obj);
            MessageBox.Show("Guardado con éxito");
        }
    }
}
