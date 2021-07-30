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
    public partial class abmdirectivos : Formabm
    {
        public abmdirectivos()
        {
            InitializeComponent();
            lbtitulo.Text = "Alta de Directivo";
        }

        private void abmdirectivos_Load(object sender, EventArgs e)
        {
            Negocio.NInstitucion Ninst = new Negocio.NInstitucion();
            IList<Modelo.Institucion> listainstitucion= Ninst.BuscarPorstring(string.Empty);
            foreach (var item in listainstitucion)
            {
                cbinstitucion.DataSource = listainstitucion;
                cbinstitucion.DisplayMember = "Nombre";
                cbinstitucion.ValueMember = "ID";
            }
        }

        private void btbuscarcv_Click(object sender, EventArgs e)
        {
            if (ofdcv.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(ofdcv.FileName))
                {
                    tbcv.Text = ofdcv.FileName;
                }
            }
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Modelo.Directivos obj = new Modelo.Directivos();
            Negocio.Ndirectivos Ndirec = new Negocio.Ndirectivos();

            byte[] bytes = null;
            Stream mystream = ofdcv.OpenFile();
            using(MemoryStream ms= new MemoryStream())
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

            Ndirec.Altas(obj);
            MessageBox.Show("Guardado con éxito");
        }
    }
}
