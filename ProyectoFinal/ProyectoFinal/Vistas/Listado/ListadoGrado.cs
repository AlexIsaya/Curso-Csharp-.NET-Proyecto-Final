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
    public partial class ListadoGrado : FormListado
    {
        public ListadoGrado()
        {
            InitializeComponent();
            lbtitulo.Text = "Listado de Grados";
        }

        public override void Seleccionar(DataGridViewCellEventArgs e)
        {
            base.Seleccionar(e);

            Negocio.NGrado ngrad = new Negocio.NGrado();
            Modelo.Grados grad = new Modelo.Grados();

            entidadId = (int)dgvAñoLectivo["ID", e.RowIndex].Value;
            if (entidadId != null)
            {
                bteliminar.Visible = true;
                btmodificar.Visible = true;
            }
        }

        public override void CargarGrilla()
        {
            base.CargarGrilla();

            Modelo.Niveles niv = new Modelo.Niveles();
            Negocio.NGrado ngrad = new Negocio.NGrado();

            dgvAñoLectivo.DataSource = ngrad.BuscarPorString(string.Empty);
            

            dgvAñoLectivo.Columns["ID"].Visible = false;
            dgvAñoLectivo.Columns["Habilitado"].Visible = false;
            dgvAñoLectivo.Columns["NivelesID"].Visible = false;
            dgvAñoLectivo.Columns["Divisiones"].Visible = false;
            dgvAñoLectivo.Columns["Niveles"].Visible = false;
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            Vistas.Modificar.ModificarGrado Mgrado = new Modificar.ModificarGrado(entidadId);
            Mgrado.ShowDialog();
            CargarGrilla();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Negocio.NGrado Ngrado = new Negocio.NGrado();
            Modelo.Grados grad = new Modelo.Grados(); //esta bien?
            Ngrado.Eliminar(entidadId);
            MessageBox.Show("Eliminado con éxito");
            CargarGrilla();
        }
    }
}
