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
    public partial class ModificarTurno : Formabm
    {
        int entidadidTurno;
        public ModificarTurno(int _entidad)
        {
            InitializeComponent();
            entidadidTurno = _entidad;
            lbtitulo.Text = "Modificar Turno";
        }
        private void ModificarTurno_Load(object sender, EventArgs e)
        {
            Modelo.Turnos tur = new Modelo.Turnos();
            Negocio.Nturno Ntur = new Negocio.Nturno();

            tur = Ntur.BuscarPorId(entidadidTurno);

            tbdescrip.Text = tur.Descripcion;
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Negocio.Nturno Ntur = new Negocio.Nturno();
            Modelo.Turnos obj = Ntur.BuscarPorId(entidadidTurno);

            obj.Descripcion = tbdescrip.Text;

            Ntur.Modificar(obj);
            MessageBox.Show("Modificación Realizada con éxito");
        }
    }
}
