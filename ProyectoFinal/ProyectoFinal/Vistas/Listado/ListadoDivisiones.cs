using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Negocio;

namespace ProyectoFinal.Vistas.Listado
{
    public partial class ListadoDivisiones : FormListado
    {
        public ListadoDivisiones()
        {
            InitializeComponent();
            lbtitulo.Text = "Listado de Divisiones";
        }

        public override void Seleccionar(DataGridViewCellEventArgs e)
        {
            base.Seleccionar(e);

            NDivisiones ndiv = new NDivisiones();
            Modelo.Divisiones div = new Modelo.Divisiones();

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

            Negocio.NDivisiones ndiv = new Negocio.NDivisiones();

            dgvAñoLectivo.DataSource = ndiv.BuscarPorString(string.Empty);


            dgvAñoLectivo.Columns["ID"].Visible = false;
            dgvAñoLectivo.Columns["Habilitado"].Visible = false;
            dgvAñoLectivo.Columns["GradosID"].Visible = false;
            dgvAñoLectivo.Columns["Grados"].Visible = false;
            dgvAñoLectivo.Columns["AsignacionGrados"].Visible = false;
            dgvAñoLectivo.Columns["Inscripciones"].Visible = false;
        }

        private void btmodificar_Click_1(object sender, EventArgs e)
        {
            Vistas.Modificar.ModificarDivision Mdiv = new Modificar.ModificarDivision(entidadId);
            Mdiv.ShowDialog();
            CargarGrilla();
        }

        private void bteliminar_Click_1(object sender, EventArgs e)
        {
            Negocio.NDivisiones Ndiv = new Negocio.NDivisiones();
            Modelo.Divisiones div = new Modelo.Divisiones(); //esta bien?
            Ndiv.Eliminar(entidadId);
            MessageBox.Show("Eliminado con éxito");
            CargarGrilla();
        }
    }
}
