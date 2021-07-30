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
    public partial class ModificarAñoLectivo : Formabm
    {
        int entidadidAño;
        public ModificarAñoLectivo(int _entidad)
        {
            InitializeComponent();
            entidadidAño = _entidad;
            lbtitulo.Text = "Modificar Año Lectivo";
        }

        private void ModificarAñoLectivo_Load(object sender, EventArgs e)
        {
            Modelo.AñoLectivo año = new Modelo.AñoLectivo();
            Negocio.Nañolectivo Naño = new Negocio.Nañolectivo();

            año = Naño.BuscarPorId(entidadidAño);

            tbañolectivo.Text = año.Año;
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Negocio.Nañolectivo Naño = new Negocio.Nañolectivo();
            Modelo.AñoLectivo obj = Naño.BuscarPorId(entidadidAño);

            obj.Año = tbañolectivo.Text;

            Naño.Modificar(obj);
            MessageBox.Show("Modificación Realizada con éxito");
        }
    }
}
