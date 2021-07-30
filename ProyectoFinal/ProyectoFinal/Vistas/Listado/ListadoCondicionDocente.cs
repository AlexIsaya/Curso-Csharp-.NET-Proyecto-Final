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
    public partial class ListadoCondicionDocente : FormListado
    {
        public ListadoCondicionDocente()
        {
            InitializeComponent();
            lbtitulo.Text = "Listado de Condiciones Docentes";
        }
        public override void Seleccionar(DataGridViewCellEventArgs e)
        {
            base.Seleccionar(e);

            Ncondiciondocente ncon = new Ncondiciondocente();
            Modelo.CondicionDocente con = new Modelo.CondicionDocente();

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

            Negocio.Ncondiciondocente ncon = new Negocio.Ncondiciondocente();

            dgvAñoLectivo.DataSource = ncon.BuscarPorString(string.Empty);

            dgvAñoLectivo.Columns["ID"].Visible = false;
            dgvAñoLectivo.Columns["Habilitado"].Visible = false;
            dgvAñoLectivo.Columns["Docentes"].Visible = false;
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            Vistas.Modificar.ModificarCondicionDocente Mcon = new Modificar.ModificarCondicionDocente(entidadId);
            Mcon.ShowDialog();
            CargarGrilla();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Negocio.Ncondiciondocente Ncon = new Negocio.Ncondiciondocente();
            Modelo.CondicionDocente con = new Modelo.CondicionDocente(); //esta bien?
            Ncon.Eliminar(entidadId);
            MessageBox.Show("Eliminado con éxito");
            CargarGrilla();
        }
    }
}
