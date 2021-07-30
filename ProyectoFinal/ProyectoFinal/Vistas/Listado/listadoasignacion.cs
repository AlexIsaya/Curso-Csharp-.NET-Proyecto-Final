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
    public partial class listadoasignacion : FormListado
    {
        public listadoasignacion()
        {
            InitializeComponent();
            lbtitulo.Text = "Listado de Asignación de Grados";
        }

        private void listadoasignacion_Load(object sender, EventArgs e)
        {
            Negocio.NAsignaciongrado Nas = new Negocio.NAsignaciongrado();
            dgvAñoLectivo.DataSource = Nas.buscarlistado();
            //dgvAñoLectivo.Columns.Add("ID", "ID");
            dgvAñoLectivo.Columns["ID"].Visible = false;
            //dgvAñoLectivo.Columns.Add("Nombre", "Docente");
            //dgvAñoLectivo.Columns.Add("Nombre", "Division");

        }

        public override void Seleccionar(DataGridViewCellEventArgs e)
        {
            base.Seleccionar(e);
            Negocio.NAsignaciongrado naño = new Negocio.NAsignaciongrado();
            Modelo.AsignacionGrados año = new Modelo.AsignacionGrados();

            entidadId = (int)dgvAñoLectivo["ID", e.RowIndex].Value;
            //entidadSeleccionada = naño.BuscarPorId(entidadId);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    dgvAñoLectivo.Rows.Clear();
        //    Negocio.NDocente Ndoc = new Negocio.NDocente();
        //    Modelo.Docentes doc = Ndoc.Buscar(textBox1.Text);
        //    Modelo.AsignacionGrados asig = new Modelo.AsignacionGrados();
        //    Negocio.NAsignaciongrado Nasigg = new Negocio.NAsignaciongrado();
        //    Negocio.NDivisiones Ndiv = new Negocio.NDivisiones();

        //    IList<Modelo.AsignacionGrados> listasigna = Nasigg.buscarlistaIDdocentes(doc.ID);
        //    foreach (var item in listasigna)
        //    {
        //        if (item.DocentesID == doc.ID)
        //            asig = item;
        //        Modelo.Divisiones div = Ndiv.BuscarPorId(asig.DivisionesID);
        //        object[] arrayobj = { asig.ID, doc.Nombre, div.Nombre };
        //        dgvAñoLectivo.Rows.Add(arrayobj);
        //    }
        //}

        private void bteliminar_Click(object sender, EventArgs e)
        {
            Negocio.NAsignaciongrado Nasig = new Negocio.NAsignaciongrado();
            Nasig.Eliminar(entidadId);
            MessageBox.Show("Eliminado con exito");
            this.Close();
            listadoasignacion frmc = new listadoasignacion();
            frmc.ShowDialog();
        }
    }
}
