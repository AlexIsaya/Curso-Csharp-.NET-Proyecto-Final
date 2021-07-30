using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Vistas.Modificar
{
    public partial class ModificarCondicionDocente : Formabm
    {
        int entidadidCondicion;
        public ModificarCondicionDocente(int _entidad)
        {
            InitializeComponent();
            entidadidCondicion = _entidad;
            lbtitulo.Text = "Modificar Condición Docente";
        }
        private void ModificarCondicionDocente_Load(object sender, EventArgs e)
        {
            Modelo.CondicionDocente con = new Modelo.CondicionDocente();
            Negocio.Ncondiciondocente Ncon = new Negocio.Ncondiciondocente();

            con = Ncon.BuscarPorId(entidadidCondicion);

            tbdescripcion.Text = con.Descripcion;
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Negocio.Ncondiciondocente Ncon = new Negocio.Ncondiciondocente();
            Modelo.CondicionDocente obj = Ncon.BuscarPorId(entidadidCondicion);

            obj.Descripcion = tbdescripcion.Text;

            Ncon.Modificar(obj);
            MessageBox.Show("Modificación Realizada con éxito");
        }
    }
}
