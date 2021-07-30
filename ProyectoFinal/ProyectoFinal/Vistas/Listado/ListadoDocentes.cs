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
    public partial class ListadoDocentes : FormListado
    {
        public ListadoDocentes()
        {
            InitializeComponent();
            lbtitulo.Text = "Listado de Docentes";
        }

        public override void Seleccionar(DataGridViewCellEventArgs e)
        {
            base.Seleccionar(e);

            Negocio.NDocente ndoc = new Negocio.NDocente();
            Modelo.Docentes doc = new Modelo.Docentes();

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

            Negocio.NDocente ndoc = new Negocio.NDocente();

            dgvAñoLectivo.DataSource = ndoc.Buscarporstring(string.Empty);

            dgvAñoLectivo.Columns["ID"].Visible = false;
            dgvAñoLectivo.Columns["Habilitado"].Visible = false;
            dgvAñoLectivo.Columns["CondicionDocenteID"].Visible = false;
            dgvAñoLectivo.Columns["AsignacionGrados"].Visible = false;
            dgvAñoLectivo.Columns["CondicionDocente"].Visible = false;
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            Vistas.Modificar.Mdocente Mdoc = new Modificar.Mdocente(entidadId);
            Mdoc.ShowDialog();
            CargarGrilla();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Negocio.NDocente Ndoc = new Negocio.NDocente();
            Ndoc.Eliminar(entidadId);
            MessageBox.Show("Eliminado con éxito");
            CargarGrilla();
        }
    }
}
