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
    public partial class abminstitucion : Formabm
    {
        public abminstitucion()
        {
            InitializeComponent();
            lbtitulo.Text = "Alta de Institución";
        }

        private void abminstitucion_Load(object sender, EventArgs e)
        {

        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Negocio.NInstitucion Ninst = new Negocio.NInstitucion();
            Modelo.Institucion obj = new Modelo.Institucion();

            obj.Nombre = tbnombre.Text;
            obj.Descripcion = tbdescrip.Text;
            obj.CodigoMin = tbcodimin.Text;
            obj.Direccion = tbdirec.Text;
            obj.Telefono = tbtel.Text;

            Ninst.Altas(obj);
            MessageBox.Show("Guardado con éxito");
        }
    }
}
