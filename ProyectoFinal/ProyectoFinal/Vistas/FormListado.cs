using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Negocio;

namespace ProyectoFinal.Vistas
{
    public partial class FormListado : FormBase
    {
        protected int entidadId;
       // Modelo.AñoLectivo entidadSeleccionada;
        public FormListado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

     

        private void FormListado_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            
            
        }

        public virtual void CargarGrilla()
        {
            
        }

        private void dgvAñoLectivo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar(e);
           
        }

        public virtual void Seleccionar(DataGridViewCellEventArgs e)
        {
            //Nañolectivo naño = new Nañolectivo();
            //Modelo.AñoLectivo año = new Modelo.AñoLectivo();

            //entidadId = (int)dgvAñoLectivo["ID", e.RowIndex].Value;
            //entidadSeleccionada = naño.BuscarPorId(entidadId);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
