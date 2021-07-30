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
    public partial class abmdocente : Formabm
    {
        public abmdocente()
        {
            InitializeComponent();
            lbtitulo.Text = "Alta de Docente";
        }

        private void abmdocente_Load(object sender, EventArgs e)
        {
            Negocio.Ncondiciondocente Ndoc = new Negocio.Ncondiciondocente();
            IList<Modelo.CondicionDocente> listacondicion = Ndoc.BuscarPorString(string.Empty);
            foreach (var item in listacondicion)
            {
                cbcondicion.DataSource = listacondicion;
                cbcondicion.DisplayMember = "Descripcion";
                cbcondicion.ValueMember = "ID";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Modelo.Docentes obj = new Modelo.Docentes();
            Modelo.CondicionDocente condi = new Modelo.CondicionDocente();
            Negocio.NDocente Ndoc = new Negocio.NDocente();
            obj.Apellido = tbapellido.Text;
            obj.Nombre = tbnombre.Text;
            obj.Dni = tbdni.Text;
            obj.Telefono = tbtelefono.Text;
            obj.CondicionDocenteID = ((Modelo.CondicionDocente)cbcondicion.SelectedItem).ID;
            Ndoc.Altas(obj);
            MessageBox.Show("Guardado con éxito");
        }
    }
}
