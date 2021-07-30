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

namespace ProyectoFinal.Vistas.Modificar
{
    public partial class Mdocente : Formabm
    {
        int entidadiddocentes;
        public Mdocente( int _entidad)
        {
            InitializeComponent();
            entidadiddocentes = _entidad;
            lbtitulo.Text = "Modificar Docente";
        }

        private void Mdocente_Load(object sender, EventArgs e)
        {
            Negocio.Ncondiciondocente Ncon = new Negocio.Ncondiciondocente();
            IList<Modelo.CondicionDocente> listacondicion = Ncon.BuscarPorString(string.Empty);
            foreach (var item in listacondicion)
            {
                cbcondicion.DataSource = listacondicion;
                cbcondicion.DisplayMember = "Descripcion";
                cbcondicion.ValueMember = "ID";
            }
            

            Negocio.NDocente Ndoc = new Negocio.NDocente();
            Modelo.Docentes doc = Ndoc.BuscarPorId(entidadiddocentes);
            Modelo.CondicionDocente cond = Ncon.BuscarPorId(doc.CondicionDocenteID);

            tbapellido.Text = doc.Apellido;
            tbnombre.Text = doc.Nombre;
            tbdni.Text = doc.Dni;
            tbtelefono.Text = doc.Telefono;           
            cbcondicion.Text = cond.Descripcion;
            
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {           
            Negocio.NDocente Ndoc = new Negocio.NDocente();
            Modelo.Docentes obj = Ndoc.BuscarPorId(entidadiddocentes);

            obj.Nombre = tbnombre.Text;
            obj.Apellido = tbapellido.Text;
            obj.Dni = tbdni.Text;
            obj.Telefono = tbtelefono.Text;
            obj.CondicionDocenteID = ((Modelo.CondicionDocente)cbcondicion.SelectedItem).ID;

            Ndoc.Modificar(obj);
            MessageBox.Show("Modificación Realizada con éxito");
        }

        private void btregresar_Click(object sender, EventArgs e)
        {

        }
    }
}
