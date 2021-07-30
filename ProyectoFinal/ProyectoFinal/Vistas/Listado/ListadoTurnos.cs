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
    public partial class ListadoTurnos : FormListado
    {
        public ListadoTurnos()
        {
            InitializeComponent();
            lbtitulo.Text = "Listado de Turnos";
        }

        public override void Seleccionar(DataGridViewCellEventArgs e)
        {
            base.Seleccionar(e);

            Nturno ndiv = new Nturno();
            Modelo.Turnos div = new Modelo.Turnos();

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

            Negocio.Nturno ntur = new Negocio.Nturno();

            dgvAñoLectivo.DataSource = ntur.BuscarPorString(string.Empty);


            dgvAñoLectivo.Columns["ID"].Visible = false;
            dgvAñoLectivo.Columns["Habilitado"].Visible = false;
            dgvAñoLectivo.Columns["Niveles"].Visible = false;
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            Vistas.Modificar.ModificarTurno Mtur = new Modificar.ModificarTurno(entidadId);
            Mtur.ShowDialog();
            CargarGrilla();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Negocio.Nturno ntur = new Negocio.Nturno();
            Modelo.Turnos tur = new Modelo.Turnos(); //esta bien?
            ntur.Eliminar(entidadId);
            MessageBox.Show("Eliminado con éxito");
            CargarGrilla();
        }
    }
}
