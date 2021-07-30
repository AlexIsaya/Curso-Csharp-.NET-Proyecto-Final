using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Vistas
{
    public partial class Formabm : FormBase
    {
        public Formabm()
        {
            InitializeComponent();
        }

        private void btregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
