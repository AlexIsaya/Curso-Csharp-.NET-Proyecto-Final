using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Vistas.abm
{
    public partial class abmañolectivo : Formabm
    {
        Validacion1.ValidacionCompleta val = new Validacion1.ValidacionCompleta();
        public abmañolectivo()
        {
            InitializeComponent();
            lbtitulo.Text = "Alta de Año Lectivo";
        }


        private void abmañolectivo_Load(object sender, EventArgs e)
        {

        }

        private void btaceptar_Click(object sender, EventArgs e)
        {

                Modelo.AñoLectivo obj = new Modelo.AñoLectivo();
                Negocio.Nañolectivo Naño = new Negocio.Nañolectivo();

                 obj.Año = tbañolectivo.Text;

                  Naño.Altas(obj);
                  MessageBox.Show("Guardado con éxito");
            
        }

        private void tbañolectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }
    }
}
