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
    public partial class abmcondiciondocente : Formabm
    {
        public abmcondiciondocente()
        {
            InitializeComponent();
            lbtitulo.Text = "Alta de Condición Docente";
        }

        private void abmcondiciondocente_Load(object sender, EventArgs e)
        {

        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Negocio.Ncondiciondocente Ncondi = new Negocio.Ncondiciondocente();
            Modelo.CondicionDocente obj = new Modelo.CondicionDocente();
            obj.Descripcion=tbdescripcion.Text;
            Ncondi.Altas(obj);
            MessageBox.Show("Guardado con éxito");
        }
    }
}
