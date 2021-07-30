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
    public partial class ListadoInscripciones : FormListado
    {
        Negocio.NInscripcion Nins = new Negocio.NInscripcion();
        public ListadoInscripciones()
        {
            InitializeComponent();
            lbtitulo.Text = "Listado de Inscripciones";
        }

        public override void Seleccionar(DataGridViewCellEventArgs e)
        {
            base.Seleccionar(e);


            Modelo.Inscripciones ins = new Modelo.Inscripciones();

            entidadId = (int)dgvAñoLectivo["ID", e.RowIndex].Value;
            //entidadSeleccionada = naño.BuscarPorId(entidadId);
        }

        private void ListadoInscripciones_Load(object sender, EventArgs e)
        {
            dgvAñoLectivo.DataSource = Nins.buscarlistado();
            dgvAñoLectivo.Columns["ID"].Visible = false;

        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Nins.Eliminar(entidadId);
            MessageBox.Show("Eliminado con exito");
            ListadoInscripciones frmc = new ListadoInscripciones();
            this.Close();
            frmc.ShowDialog();

        }
    }
}
