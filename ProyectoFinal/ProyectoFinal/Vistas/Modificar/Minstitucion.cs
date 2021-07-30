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
    public partial class Minstitucion : Formabm
    {
        int entidadidinstitucion;
        public Minstitucion(int _entidad)
        {
            InitializeComponent();
            entidadidinstitucion = _entidad;
            lbtitulo.Text = "Modificar Institución";
        }

        private void Minstitucion_Load(object sender, EventArgs e)
        {
            Modelo.Institucion ins = new Modelo.Institucion();
            Negocio.NInstitucion Nins = new Negocio.NInstitucion();

            ins = Nins.BuscarPorId(entidadidinstitucion);

            tbnombre.Text = ins.Nombre;
            tbdescrip.Text = ins.Descripcion;
            tbcodimin.Text = ins.CodigoMin;
            tbtel.Text = ins.Telefono;
            tbdirec.Text = ins.Direccion;
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Negocio.NInstitucion Nins = new Negocio.NInstitucion();
            Modelo.Institucion obj = Nins.BuscarPorId(entidadidinstitucion);

            obj.Nombre = tbnombre.Text;
            obj.Descripcion = tbdescrip.Text;
            obj.CodigoMin = tbcodimin.Text;
            obj.Telefono = tbtel.Text;
            obj.Direccion = tbdirec.Text;

            Nins.Modificar(obj);
            MessageBox.Show("Modificación Realizada con éxito");
        }


    }
}
