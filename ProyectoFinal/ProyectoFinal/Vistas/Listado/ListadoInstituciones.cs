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
    public partial class ListadoInstituciones : FormListado

    {
        public ListadoInstituciones()
        {
            InitializeComponent();
            lbtitulo.Text = "Listado de Instituciones";
        }

        public override void Seleccionar(DataGridViewCellEventArgs e)
        {
            base.Seleccionar(e);

            Negocio.NInstitucion nins = new Negocio.NInstitucion();
            Modelo.Institucion ins = new Modelo.Institucion();
            entidadId = (int)dgvAñoLectivo["ID", e.RowIndex].Value;

            if (entidadId != null)
            {
                bteliminar.Visible = true;
                btmodificar.Visible = true;
            }
            //entidadSeleccionada = naño.BuscarPorId(entidadId);
        }

        public override void CargarGrilla()
        {
            base.CargarGrilla();

            Negocio.NInstitucion nins = new Negocio.NInstitucion();

            dgvAñoLectivo.DataSource = nins.BuscarPorstring(string.Empty);

            dgvAñoLectivo.Columns["ID"].Visible = false;
            dgvAñoLectivo.Columns["Habilitado"].Visible = false;
            dgvAñoLectivo.Columns["Directivos"].Visible = false;
            dgvAñoLectivo.Columns["Niveles"].Visible = false;
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            Vistas.Modificar.Minstitucion Mins = new Modificar.Minstitucion(entidadId);
            Mins.ShowDialog();
            CargarGrilla();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Negocio.NInstitucion Nins = new Negocio.NInstitucion();
            Nins.Eliminar(entidadId);
            MessageBox.Show("Eliminado con éxito");
            CargarGrilla();
        }
    }
}
