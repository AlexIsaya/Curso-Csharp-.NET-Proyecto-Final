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
    public partial class ModificarDirectivo : Formabm
    {
        int entidadiddirectivos;
        public ModificarDirectivo(int _entidad)
        {
            InitializeComponent();
            entidadiddirectivos = _entidad;
            lbtitulo.Text = "Modificar Directivo";
        }

        private void ModificarDirectivo_Load(object sender, EventArgs e)
        {
            Negocio.NInstitucion Ninst = new Negocio.NInstitucion();
            IList<Modelo.Institucion> listainstitucion = Ninst.BuscarPorstring(string.Empty);
            foreach (var item in listainstitucion)
            {
                cbinstitucion.DataSource = listainstitucion;
                cbinstitucion.DisplayMember = "Nombre";
                cbinstitucion.ValueMember = "ID";
            }

            Negocio.Ndirectivos Ndir = new Negocio.Ndirectivos();
            Modelo.Directivos dir = new Modelo.Directivos();
            Modelo.Institucion ins = new Modelo.Institucion();
            dir = Ndir.BuscarPorId(entidadiddirectivos);
            ins = Ninst.BuscarPorId(dir.InstitucionID);

            tbnombre.Text = dir.Nombre;
            tbapellido.Text = dir.Apellido;
            tbdni.Text = dir.Dni;
            tbtelefono.Text = dir.Telefono;
            tbdireccion.Text = dir.Direccion;
            cbinstitucion.Text = ins.Nombre;

        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Negocio.Ndirectivos Ndirec = new Negocio.Ndirectivos();
            Modelo.Directivos obj = Ndirec.BuscarPorId(entidadiddirectivos);

            byte[] bytes = null;
            Stream mystream = ofdcv.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                mystream.CopyTo(ms);
                bytes = ms.ToArray();
            }

            obj.Nombre = tbnombre.Text;
            obj.Apellido = tbapellido.Text;
            obj.Dni = tbdni.Text;
            obj.Telefono = tbtelefono.Text;
            obj.Direccion = tbdireccion.Text;
            obj.InstitucionID = ((Modelo.Institucion)cbinstitucion.SelectedItem).ID;


            obj.Cv = bytes;

            Ndirec.Modificar(obj);
            MessageBox.Show("Modificación Realizada con éxito");
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            if (ofdcv.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(ofdcv.FileName))
                {
                    tbcv.Text = ofdcv.FileName;
                }
            }
        }
    }
}
