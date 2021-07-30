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
    public partial class ListadoNiveles : FormListado
    {
        public ListadoNiveles()
        {
            InitializeComponent();
            lbtitulo.Text = "Listado de Niveles";
        }

        public override void Seleccionar(DataGridViewCellEventArgs e)
        {
            base.Seleccionar(e);

            Nnivel ndiv = new Nnivel();
            Modelo.Niveles div = new Modelo.Niveles();

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

            Negocio.Nnivel ndiv = new Negocio.Nnivel();

            dgvAñoLectivo.DataSource = ndiv.BuscarPorString(string.Empty);

            dgvAñoLectivo.Columns["ID"].Visible = false;
            dgvAñoLectivo.Columns["Habilitado"].Visible = false;
            dgvAñoLectivo.Columns["InstitucionID"].Visible = false;           
            dgvAñoLectivo.Columns["TurnoID"].Visible = false;
            dgvAñoLectivo.Columns["Grados"].Visible = false;
            dgvAñoLectivo.Columns["Institucion"].Visible = false;
            dgvAñoLectivo.Columns["Turnos"].Visible = false;
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            Vistas.Modificar.ModificarNivel Mniv = new Modificar.ModificarNivel(entidadId);
            Mniv.ShowDialog();
            CargarGrilla();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Negocio.Nnivel Nniv = new Negocio.Nnivel();
            Modelo.Niveles niv = new Modelo.Niveles();
            Nniv.Eliminar(entidadId);
            MessageBox.Show("Eliminado con éxito");
            CargarGrilla();
        }

    }
}
