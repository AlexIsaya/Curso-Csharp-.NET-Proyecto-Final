using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Vistas.Modificar
{
    public partial class ModificarDivision : Formabm
    {
        int entidadidDivision;
        public ModificarDivision(int _entidad)
        {
            InitializeComponent();
            entidadidDivision = _entidad;
            lbtitulo.Text = "Modificar División";
        }

        private void ModificarDivision_Load(object sender, EventArgs e)
        {
            Negocio.NGrado Ngrado = new Negocio.NGrado();
            IList<Modelo.Grados> listagrados = Ngrado.BuscarPorString(string.Empty);
            foreach (var item in listagrados)
            {
                cbgrado.DataSource = listagrados;
                cbgrado.DisplayMember = "Nombre";
                cbgrado.ValueMember = "ID";
            }

            Modelo.Divisiones div = new Modelo.Divisiones();
            Negocio.NDivisiones Ndiv = new Negocio.NDivisiones();
            Modelo.Grados grado = new Modelo.Grados();

            div = Ndiv.BuscarPorId(entidadidDivision);
            grado = Ngrado.BuscarPorId(div.GradosID);

            tbnombre.Text = div.Nombre;
            cbgrado.Text = grado.Nombre;  //no se por que no lo toma al id desde el datagridview
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Negocio.NDivisiones Ndiv = new Negocio.NDivisiones();
            Modelo.Divisiones obj = Ndiv.BuscarPorId(entidadidDivision);

            obj.Nombre = tbnombre.Text;
            obj.GradosID = ((Modelo.Grados)cbgrado.SelectedItem).ID;

            Ndiv.Modificar(obj);
            MessageBox.Show("Modificación Realizada con éxito");
        }
    }
}
