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
    public partial class ListadoAñoLectivo : FormListado
    {
        public ListadoAñoLectivo()
        {
            InitializeComponent();
            lbtitulo.Text = "Listado de Años Lectivos";
        }
        public override void Seleccionar(DataGridViewCellEventArgs e)
        {
            base.Seleccionar(e);

            Nañolectivo naño = new Nañolectivo();
            Modelo.AñoLectivo año = new Modelo.AñoLectivo();

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

            Negocio.Nañolectivo naño = new Negocio.Nañolectivo();

            dgvAñoLectivo.DataSource = naño.BuscarPorString(string.Empty);

            dgvAñoLectivo.Columns["ID"].Visible = false;
            dgvAñoLectivo.Columns["Habilitado"].Visible = false;
            dgvAñoLectivo.Columns["Inscripciones"].Visible = false;
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            Vistas.Modificar.ModificarAñoLectivo Mdiv = new Modificar.ModificarAñoLectivo(entidadId);
            Mdiv.ShowDialog();
            CargarGrilla();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Negocio.Nañolectivo naño = new Negocio.Nañolectivo();
            Modelo.AñoLectivo año = new Modelo.AñoLectivo(); //esta bien?
            naño.Eliminar(entidadId);
            MessageBox.Show("Eliminado con éxito");
            CargarGrilla();
        }
    }
}
