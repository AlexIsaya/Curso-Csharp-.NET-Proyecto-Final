using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinal.Vistas.abm
{
    public partial class abminscripcion : Formabm
    {
        int EntidadIDAlumno;
        int EntidadIDDivision;
        public abminscripcion()
        {
            InitializeComponent();
            lbtitulo.Text = "Inscripción de Alumnos";
        }

        private void abminscripcion_Load(object sender, EventArgs e)
        {
            Negocio.NDivisiones Ndiv = new Negocio.NDivisiones();          
            Modelo.Divisiones div = new Modelo.Divisiones();          
            dgvdivisiones.DataSource = Ndiv.BuscarPorString(string.Empty);
          
            dgvdivisiones.Columns["ID"].Visible = false;
            dgvdivisiones.Columns["Nombre"].HeaderText = "Nombre";
            dgvdivisiones.Columns["GradosID"].Visible = false;
            dgvdivisiones.Columns["Habilitado"].Visible = false;
            dgvdivisiones.Columns["AsignacionGrados"].Visible = false;
            dgvdivisiones.Columns["Grados"].Visible = false;
            dgvdivisiones.Columns["Inscripciones"].Visible = false;

            Negocio.NAlumno Nalu = new Negocio.NAlumno();
            Modelo.Alumnos alu = new Modelo.Alumnos();
            dgvalumnos.DataSource = Nalu.Buscar(string.Empty);

            dgvalumnos.Columns["ID"].Visible = false;
            dgvalumnos.Columns["Apellido"].HeaderText = "Apellido";
            dgvalumnos.Columns["Nombre"].HeaderText = "Nombre";
            dgvalumnos.Columns["Dni"].HeaderText = "Dni";
            dgvalumnos.Columns["Fecha"].HeaderText = "Fecha";
            dgvalumnos.Columns["Direccion"].HeaderText = "Direccion";
            dgvalumnos.Columns["Telefono"].HeaderText = "Telefono";
            dgvalumnos.Columns["Padre"].HeaderText = "Padre";
            dgvalumnos.Columns["Madre"].HeaderText = "Madre";
            dgvalumnos.Columns["Tutor"].HeaderText = "Tutor";
            dgvalumnos.Columns["Enfermedades"].HeaderText = "Enfermedades";
            dgvalumnos.Columns["Observaciones"].HeaderText = "Observaciones";
            dgvalumnos.Columns["Foto"].Visible = false;
            dgvalumnos.Columns["Habilitado"].Visible = false;
            dgvalumnos.Columns["Inscripciones"].Visible = false;

            Negocio.Nañolectivo Naño = new Negocio.Nañolectivo();
            IList<Modelo.AñoLectivo> año = Naño.BuscarPorString(string.Empty);

            foreach (var item in año)
            {
                cbañolectivo.DataSource = año;
                cbañolectivo.DisplayMember = "Año";
                cbañolectivo.ValueMember = "ID";
            }

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Negocio.NDivisiones Ndiv = new Negocio.NDivisiones();
            dgvdivisiones.DataSource = Ndiv.BuscarPorString(tbbuscardivision.Text);
        }

        private void dgvalumnos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Negocio.NAlumno Ndoc = new Negocio.NAlumno();
            Modelo.Alumnos doc = new Modelo.Alumnos();
            EntidadIDAlumno = (int)dgvalumnos["ID", e.RowIndex].Value;
            doc = Ndoc.BuscarPorId(EntidadIDAlumno);
            tbalumno.Text = doc.Apellido + " " + doc.Nombre;

            var bytes = doc.Foto;
            var imagen = new MemoryStream(bytes);
            Image foto = Image.FromStream(imagen);

            pictureBox1.Image = foto;
        }

        private void dgvdivisiones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Negocio.NDivisiones Ndiv = new Negocio.NDivisiones();
            Modelo.Divisiones div = new Modelo.Divisiones();
            Negocio.NGrado Ngrad = new Negocio.NGrado();
            Modelo.Grados grad = new Modelo.Grados();
            EntidadIDDivision = (int)dgvdivisiones["ID", e.RowIndex].Value;
            div = Ndiv.BuscarPorId(EntidadIDDivision);
            grad = Ngrad.BuscarPorId(EntidadIDDivision);
            tbdivision.Text = div.Nombre + " " + grad.Nombre;
        }

        private void btbuscaralumno_Click(object sender, EventArgs e)
        {
            Negocio.NAlumno Ndiv = new Negocio.NAlumno();
            dgvalumnos.DataSource = Ndiv.Buscar(tbbuscaralumno.Text);
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Negocio.NInscripcion Nins = new Negocio.NInscripcion();
            Modelo.Inscripciones obj = new Modelo.Inscripciones();

            obj.AlumnosID = EntidadIDAlumno;
            obj.DivisionesID = EntidadIDDivision;
            obj.AñoLectivoID = ((Modelo.AñoLectivo)cbañolectivo.SelectedItem).ID;
            obj.Fecha = dtpInscripcion.Value;
            obj.Observaciones = tbobservaciones.Text;

            Nins.Altas(obj);
            MessageBox.Show("Guardado con éxito");
        }
    }
}
