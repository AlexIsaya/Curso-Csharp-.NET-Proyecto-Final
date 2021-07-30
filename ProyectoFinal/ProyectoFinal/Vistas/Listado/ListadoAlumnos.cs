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
    public partial class ListadoAlumnos : FormListado
    {
        public ListadoAlumnos()
        {
            InitializeComponent();
            lbtitulo.Text = "Listado de Alumnos";
        }

        public override void Seleccionar(DataGridViewCellEventArgs e)
        {
            base.Seleccionar(e);

            NAlumno nalu = new NAlumno();
            Modelo.AñoLectivo año = new Modelo.AñoLectivo();

            entidadId = (int)dgvAñoLectivo["ID", e.RowIndex].Value;
            if(entidadId != null)
            {
                bteliminar.Visible = true;
                btmodificar.Visible = true;
            }

            //entidadSeleccionada = naño.BuscarPorId(entidadId);
        }

        public override void CargarGrilla()
        {
            base.CargarGrilla();

            var nalu = new Negocio.NAlumno();

            dgvAñoLectivo.DataSource = nalu.Buscar(string.Empty);

            dgvAñoLectivo.Columns["ID"].Visible = false;
            dgvAñoLectivo.Columns["Foto"].Visible = false;
            dgvAñoLectivo.Columns["Inscripciones"].Visible = false;
            dgvAñoLectivo.Columns["Habilitado"].Visible = false;
        
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            Vistas.Modificar.Modificaralumno Malu = new Modificar.Modificaralumno(entidadId);
            Malu.ShowDialog();
            CargarGrilla();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Negocio.NAlumno Nalu = new NAlumno();
            Nalu.Eliminar(entidadId);
            MessageBox.Show("Eliminado con éxito");
            CargarGrilla();
        }
    }
}
