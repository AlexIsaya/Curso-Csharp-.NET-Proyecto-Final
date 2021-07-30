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
    public partial class abmdivisiones : Formabm
    {
        public abmdivisiones()
        {
            InitializeComponent();
            lbtitulo.Text = "Alta de División";
        }

        private void abmdivisiones_Load(object sender, EventArgs e)
        {
            Negocio.NGrado Ngrado = new Negocio.NGrado();
            IList<Modelo.Grados> listagrados = Ngrado.BuscarPorString(string.Empty);

            foreach (var item in listagrados)
            {
                cbgrado.DataSource = listagrados;
                cbgrado.DisplayMember = "Nombre";
                cbgrado.ValueMember = "ID";
            }
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Modelo.Divisiones obj = new Modelo.Divisiones();
            Negocio.NDivisiones Ndiv = new Negocio.NDivisiones();

            obj.Nombre = tbnombre.Text;
            obj.GradosID = ((Modelo.Grados)cbgrado.SelectedItem).ID;

            Ndiv.Altas(obj);
            MessageBox.Show("Guardado con éxito");
        }
    }
}
