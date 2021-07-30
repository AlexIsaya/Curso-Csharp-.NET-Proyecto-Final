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
    public partial class abmgrado : Formabm
    {
        public abmgrado()
        {
            InitializeComponent();
            lbtitulo.Text = "Alta de Grado";
        }

        private void abmgrado_Load(object sender, EventArgs e)
        {
            Negocio.Nnivel Nniv = new Negocio.Nnivel();
            IList<Modelo.Niveles> listaniveles = Nniv.BuscarPorString(string.Empty);
            foreach (var item in listaniveles)
            {
                cbnivel.DataSource = listaniveles;
                cbnivel.DisplayMember = "Nombre";
                cbnivel.ValueMember = "ID";              
            }
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Modelo.Grados obj = new Modelo.Grados();
            Negocio.NGrado Ngrad = new Negocio.NGrado();

            obj.Nombre = tbnombre.Text;
            obj.Descripcion = tbdescripcion.Text;
            obj.NivelesID = ((Modelo.Niveles)cbnivel.SelectedItem).ID;

            Ngrad.Altas(obj);
            MessageBox.Show("Guardado con éxito");
        }
    }
}
