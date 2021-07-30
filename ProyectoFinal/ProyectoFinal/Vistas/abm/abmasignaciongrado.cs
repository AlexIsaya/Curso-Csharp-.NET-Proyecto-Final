using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Vistas.abm
{
    public partial class abmasignaciongrado : Formabm
    {
        int EntidadIDdocente;
        int EntidadIDdivision;
        public abmasignaciongrado()
        {
            InitializeComponent();
            lbtitulo.Text = "Asignación de Grado a Docentes";
        }

        private void abmasignaciongrado_Load(object sender, EventArgs e)
        {
            Negocio.NDocente Ndoc = new Negocio.NDocente();
            Negocio.NDivisiones Ndiv = new Negocio.NDivisiones();
            Negocio.NGrado Ngrad = new Negocio.NGrado();
            Modelo.Divisiones div = new Modelo.Divisiones();

            dgvdocentes.DataSource = Ndoc.Buscarporstring(string.Empty);
            dgvdivisiones.DataSource = Ndiv.BuscarPorString(string.Empty);
            

            dgvdocentes.Columns["ID"].Visible = false;
            dgvdocentes.Columns["Apellido"].HeaderText = "Apellido";
            dgvdocentes.Columns["Nombre"].HeaderText = "Nombre";
            dgvdocentes.Columns["Dni"].HeaderText = "Dni";
            dgvdocentes.Columns["Telefono"].HeaderText = "Telefono";
            dgvdocentes.Columns["CondicionDocenteID"].Visible = false;
            dgvdocentes.Columns["Habilitado"].Visible = false;
            dgvdocentes.Columns["AsignacionGrados"].Visible = false;
            dgvdocentes.Columns["CondicionDocente"].Visible = false;
            dgvdivisiones.Columns["ID"].Visible = false;
            dgvdivisiones.Columns["Nombre"].HeaderText = "Nombre";
            dgvdivisiones.Columns["GradosID"].Visible = false;
            dgvdivisiones.Columns["Habilitado"].Visible = false;
            dgvdivisiones.Columns["AsignacionGrados"].Visible = false;
            dgvdivisiones.Columns["Grados"].Visible = false;
            dgvdivisiones.Columns["Inscripciones"].Visible = false;
         
        }

        private void btbuscardocente_Click(object sender, EventArgs e)
        {
            Negocio.NDocente Ncod = new Negocio.NDocente();
            dgvdocentes.DataSource = Ncod.Buscarporstring(tbbuscardocente.Text);
        }

        private void dgvdocentes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           Negocio.NDocente Ndoc = new Negocio.NDocente();
           Modelo.Docentes doc = new Modelo.Docentes();
           EntidadIDdocente = (int)dgvdocentes["ID", e.RowIndex].Value;
           doc = Ndoc.BuscarPorId(EntidadIDdocente);
           tbdocente.Text = doc.Apellido +" "+ doc.Nombre;
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Modelo.AsignacionGrados doc = new Modelo.AsignacionGrados();
            Negocio.NAsignaciongrado Nasi = new Negocio.NAsignaciongrado();

            doc.DocentesID = EntidadIDdocente;
            doc.DivisionesID = EntidadIDdivision;
            Nasi.Altas(doc);
            MessageBox.Show("Guardado con éxito");
        }

        private void btbuscardivision_Click(object sender, EventArgs e)
        {
            Negocio.NDivisiones Ndiv = new Negocio.NDivisiones();
            dgvdivisiones.DataSource = Ndiv.BuscarPorString(tbbuscardivision.Text);
        }

        private void dgvdivisiones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Negocio.NDivisiones Ndiv = new Negocio.NDivisiones();
            Modelo.Divisiones div = new Modelo.Divisiones();
            Negocio.NGrado Ngrad = new Negocio.NGrado();
            Modelo.Grados grad = new Modelo.Grados();
            EntidadIDdivision = (int)dgvdivisiones["ID", e.RowIndex].Value;
            div = Ndiv.BuscarPorId(EntidadIDdivision);
            grad = Ngrad.BuscarPorId(EntidadIDdivision);
            tbdivision.Text = div.Nombre + " " + grad.Nombre;
        }
    }
}
