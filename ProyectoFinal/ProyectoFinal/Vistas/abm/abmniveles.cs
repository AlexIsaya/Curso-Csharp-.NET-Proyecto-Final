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
    public partial class abmniveles : Formabm
    {
        public abmniveles()
        {
            InitializeComponent();
            lbtitulo.Text = "Alta de Nivel Escolar";
        }

        private void abmniveles_Load(object sender, EventArgs e)
        {
            Negocio.NInstitucion Ndoc = new Negocio.NInstitucion();
            Negocio.Nturno Nturn = new Negocio.Nturno();
            IList<Modelo.Institucion> listainstitucion = Ndoc.BuscarPorstring(string.Empty);
            IList<Modelo.Turnos> listaturno = Nturn.BuscarPorString(string.Empty);
            foreach (var item in listainstitucion)
            {
                cbinstitucion.DataSource = listainstitucion;
                cbinstitucion.DisplayMember = "Nombre";
                cbinstitucion.ValueMember = "ID";
            }
            foreach (var item in listaturno)
            {
                cbturno.DataSource = listaturno;
                cbturno.DisplayMember = "Descripcion";
                cbturno.ValueMember = "ID";
            }
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Modelo.Niveles obj = new Modelo.Niveles();
            Negocio.Nnivel Nniv = new Negocio.Nnivel();

            obj.Nombre = tbnombre.Text;
            obj.InstitucionID = ((Modelo.Institucion)cbinstitucion.SelectedItem).ID;
            obj.TurnoID = ((Modelo.Turnos)cbturno.SelectedItem).ID;

            Nniv.Altas(obj);
            MessageBox.Show("Guardado con éxito");
        }
    }
}
