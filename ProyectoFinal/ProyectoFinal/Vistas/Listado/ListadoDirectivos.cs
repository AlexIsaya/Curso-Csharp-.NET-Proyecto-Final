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
    public partial class ListadoDirectivos : FormListado
    {
        public ListadoDirectivos()
        {
            InitializeComponent();
            lbtitulo.Text = "Listado de Directivos";
        }

        public override void Seleccionar(DataGridViewCellEventArgs e)
        {
            base.Seleccionar(e);

            Negocio.Ndirectivos ndir = new Negocio.Ndirectivos();
            Modelo.Directivos dir = new Modelo.Directivos();

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

            Negocio.Ndirectivos ndir = new Negocio.Ndirectivos();

            dgvAñoLectivo.DataSource = ndir.Buscar(string.Empty);

            dgvAñoLectivo.Columns["ID"].Visible = false;
            dgvAñoLectivo.Columns["InstitucionID"].Visible = false;
            dgvAñoLectivo.Columns["Habilitado"].Visible = false;
            dgvAñoLectivo.Columns["Cv"].Visible = false;
            dgvAñoLectivo.Columns["Institucion"].Visible = false;
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            Vistas.Modificar.ModificarDirectivo Mdir = new Modificar.ModificarDirectivo(entidadId);
            Mdir.ShowDialog();
            CargarGrilla();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Negocio.Ndirectivos Ndir = new Negocio.Ndirectivos();
            Ndir.Eliminar(entidadId);
            MessageBox.Show("Eliminado con éxito");
            CargarGrilla();
        }
    }
}
